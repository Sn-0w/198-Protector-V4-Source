﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Confuser.Core;
using Confuser.Core.Helpers;
using Confuser.Core.Services;
using Confuser.DynCipher;
using Confuser.Renamer;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Confuser.Protections.Resources
{
	// Token: 0x02000051 RID: 81
	internal class InjectPhase : ProtectionPhase
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00002136 File Offset: 0x00000336
		public InjectPhase(ResourceProtection parent) : base(parent)
		{
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000433C File Offset: 0x0000253C
		public override ProtectionTargets Targets
		{
			get
			{
				return ProtectionTargets.Methods;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00009098 File Offset: 0x00007298
		public override string Name
		{
			get
			{
				return "Resource encryption helpers injection";
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000090B0 File Offset: 0x000072B0
		protected override void Execute(ConfuserContext context, ProtectionParameters parameters)
		{
			bool flag = parameters.Targets.Any<IDnlibDef>();
			if (flag)
			{
				bool flag2 = !UTF8String.IsNullOrEmpty(context.CurrentModule.Assembly.Culture);
				if (flag2)
				{
					context.Logger.DebugFormat("Skipping resource encryption for satellite assembly '{0}'.", new object[]
					{
						context.CurrentModule.Assembly.FullName
					});
				}
				else
				{
					ICompressionService service = context.Registry.GetService<ICompressionService>();
					INameService name = context.Registry.GetService<INameService>();
					IMarkerService marker = context.Registry.GetService<IMarkerService>();
					IRuntimeService service2 = context.Registry.GetService<IRuntimeService>();
					REContext recontext = new REContext
					{
						Random = context.Registry.GetService<IRandomService>().GetRandomGenerator(base.Parent.Id),
						Context = context,
						Module = context.CurrentModule,
						Marker = marker,
						DynCipher = context.Registry.GetService<IDynCipherService>(),
						Name = name
					};
					recontext.Mode = parameters.GetParameter<Mode>(context, context.CurrentModule, "mode", Mode.Dynamic);
					Mode mode = recontext.Mode;
					Mode mode2 = mode;
					if (mode2 != Mode.Normal)
					{
						if (mode2 != Mode.Dynamic)
						{
							throw new UnreachableException();
						}
						recontext.ModeHandler = new DynamicMode();
					}
					else
					{
						recontext.ModeHandler = new NormalMode();
					}
					MethodDef runtimeDecompressor = service.GetRuntimeDecompressor(context.CurrentModule, delegate(IDnlibDef member)
					{
						name.MarkHelper(member, marker, (Protection)this.Parent);
						bool flag3 = member is MethodDef;
						if (flag3)
						{
							ProtectionParameters.GetParameters(context, member).Remove(this.Parent);
						}
					});
					this.InjectHelpers(context, service, service2, recontext);
					this.MutateInitializer(recontext, runtimeDecompressor);
					MethodDef methodDef = context.CurrentModule.GlobalType.FindStaticConstructor();
					methodDef.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, recontext.InitMethod));
					new MDPhase(recontext).Hook();
				}
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000934C File Offset: 0x0000754C
		private void InjectHelpers(ConfuserContext context, ICompressionService compression, IRuntimeService rt, REContext moduleCtx)
		{
			string fullName = (context.Packer != null) ? "Confuser.Runtime.Resource_Packer" : "Confuser.Runtime.Resource";
			IEnumerable<IDnlibDef> enumerable = InjectHelper.Inject(rt.GetRuntimeType(fullName), context.CurrentModule.GlobalType, context.CurrentModule);
			foreach (IDnlibDef dnlibDef in enumerable)
			{
				bool flag = dnlibDef.Name == "Initialize";
				if (flag)
				{
					moduleCtx.InitMethod = (MethodDef)dnlibDef;
				}
				moduleCtx.Name.MarkHelper(dnlibDef, moduleCtx.Marker, (Protection)base.Parent);
			}
			TypeDefUser typeDefUser = new TypeDefUser("", moduleCtx.Name.RandomName(), context.CurrentModule.CorLibTypes.GetTypeRef("System", "ValueType"));
			typeDefUser.Layout = TypeAttributes.ExplicitLayout;
			typeDefUser.Visibility = TypeAttributes.NestedPrivate;
			typeDefUser.IsSealed = true;
			typeDefUser.ClassLayout = new ClassLayoutUser(1, 0U);
			moduleCtx.DataType = typeDefUser;
			context.CurrentModule.GlobalType.NestedTypes.Add(typeDefUser);
			moduleCtx.Name.MarkHelper(typeDefUser, moduleCtx.Marker, (Protection)base.Parent);
			moduleCtx.DataField = new FieldDefUser(moduleCtx.Name.RandomName(), new FieldSig(typeDefUser.ToTypeSig(true)))
			{
				IsStatic = true,
				HasFieldRVA = true,
				InitialValue = new byte[0],
				Access = FieldAttributes.PrivateScope
			};
			context.CurrentModule.GlobalType.Fields.Add(moduleCtx.DataField);
			moduleCtx.Name.MarkHelper(moduleCtx.DataField, moduleCtx.Marker, (Protection)base.Parent);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00009548 File Offset: 0x00007748
		private void MutateInitializer(REContext moduleCtx, MethodDef decomp)
		{
			moduleCtx.InitMethod.Body.SimplifyMacros(moduleCtx.InitMethod.Parameters);
			List<Instruction> list = moduleCtx.InitMethod.Body.Instructions.ToList<Instruction>();
			for (int i = 0; i < list.Count; i++)
			{
				Instruction instruction = list[i];
				IMethod method = instruction.Operand as IMethod;
				bool flag = instruction.OpCode == OpCodes.Call;
				if (flag)
				{
					bool flag2 = method.DeclaringType.Name == "Mutation" && method.Name == "Crypt";
					if (flag2)
					{
						Instruction instruction2 = list[i - 2];
						Instruction instruction3 = list[i - 1];
						Debug.Assert(instruction2.OpCode == OpCodes.Ldloc && instruction3.OpCode == OpCodes.Ldloc);
						list.RemoveAt(i);
						list.RemoveAt(i - 1);
						list.RemoveAt(i - 2);
						list.InsertRange(i - 2, moduleCtx.ModeHandler.EmitDecrypt(moduleCtx.InitMethod, moduleCtx, (Local)instruction2.Operand, (Local)instruction3.Operand));
					}
					else
					{
						bool flag3 = method.DeclaringType.Name == "Lzma" && method.Name == "Decompress";
						if (flag3)
						{
							instruction.Operand = decomp;
						}
					}
				}
			}
			moduleCtx.InitMethod.Body.Instructions.Clear();
			foreach (Instruction item in list)
			{
				moduleCtx.InitMethod.Body.Instructions.Add(item);
			}
			MutationHelper.ReplacePlaceholder(moduleCtx.InitMethod, delegate(Instruction[] arg)
			{
				List<Instruction> list2 = new List<Instruction>();
				list2.AddRange(arg);
				list2.Add(Instruction.Create(OpCodes.Dup));
				list2.Add(Instruction.Create(OpCodes.Ldtoken, moduleCtx.DataField));
				TypeRef typeRef = moduleCtx.Module.CorLibTypes.GetTypeRef("System.Runtime.CompilerServices", "RuntimeHelpers");
				MethodDef method2 = typeRef.ResolveThrow().FindMethod("InitializeArray");
				list2.Add(Instruction.Create(OpCodes.Call, moduleCtx.Module.Import(method2)));
				return list2.ToArray();
			});
			moduleCtx.Context.Registry.GetService<IConstantService>().ExcludeMethod(moduleCtx.Context, moduleCtx.InitMethod);
		}
	}
}
