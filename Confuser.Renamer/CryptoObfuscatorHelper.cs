﻿using System;
using System.Collections.Generic;

namespace Confuser.Renamer
{
	// Token: 0x02000003 RID: 3
	public static class CryptoObfuscatorHelper
	{
		// Token: 0x04000001 RID: 1
		public static List<string> instru = new List<string>
		{
			"int",
			"(int)",
			"arg_",
			"num",
			"calli",
			"System.Configration.Settings",
			"new",
			".",
			"null",
			"checked",
			"Types.EmptyTypes.Length",
			"siezof",
			"IntPtr",
			"unchecked",
			"<module>",
			"this.",
			"as ",
			"await ",
			"is ",
			"new ",
			"sizeof ",
			"typeof ",
			"true ",
			"false ",
			"stackalloc ",
			"return new ",
			"if",
			"else",
			"Assembly.GetExecutingAssembly()",
			"manifestResourceStream.Seek",
			"BitConverter.ToInt32(array)",
			"new List<WeakReference>()",
			"this.IsSingleInstance",
			"ShutdownMode.AfterMainFormCloses",
			"WeakReference weakReference = ",
			"flag = weakReference.IsAlive;",
			"RuntimeHelpers.GetObjectValue(obj)",
			"Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)",
			"System.Activator.CreateInstance<a>()",
			"saveMySettingsOnExit",
			"RuntimeHelpers.GetObjectValue(new object());",
			"this.AutoScaleMode = AutoScaleMode.Font",
			"this.StartPosition = FormStartPosition.CenterScreen;",
			"bool flag2 = flag && this.b != null;",
			"Operators.CompareString(",
			"EventHandler value2 = new EventHandler(this.j);",
			"object g([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStruct)] System.Guid, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStruct)] System.Guid)",
			"object objectValue = System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(",
			"DownloadData("
		};

		// Token: 0x04000002 RID: 2
		public static List<string> calc = new List<string>
		{
			" + ",
			" - ",
			" / ",
			" * ",
			" = ",
			" == ",
			" != ",
			" ^",
			" >> ",
			" | ",
			" ( ",
			" (( ",
			" ) ",
			" )) ",
			" [ ",
			" [[ ",
			" ] ",
			" ]] ",
			" { ",
			" } ",
			"[]",
			"()",
			".",
			"::",
			"+",
			"-",
			"*",
			"/",
			"%",
			"&",
			"|",
			"^",
			"!",
			"~",
			"=",
			"<",
			">",
			"?:",
			"++",
			"--",
			"&&",
			"||",
			"<<",
			">>",
			"==",
			"!=",
			"<=",
			">=",
			"+=",
			"-=",
			"*=",
			"/=",
			"%=",
			"&=",
			"|=",
			"^=",
			"<<=",
			">>=",
			"->",
			"??",
			"=>"
		};

		// Token: 0x04000003 RID: 3
		public static List<string> Type = new List<string>
		{
			"System.Runtime",
			"System.Runtime.Caching",
			"System.Runtime.Caching.Configuration",
			"System.Runtime.Caching.Hosting",
			"System.Runtime.CompilerServices",
			"System.Runtime.ConstrainedExecution",
			"System.Runtime.DesignerServices",
			"System.Runtime.DurableInstancing",
			"System.Runtime.ExceptionServices",
			"System.Runtime.Hosting",
			"System.Runtime.InteropServices",
			"System.Runtime.InteropServices.ComTypes",
			"System.Runtime.InteropServices.Expando",
			"System.Runtime.InteropServices.WindowsRuntime",
			"System.Runtime.Remoting",
			"System.Runtime.Remoting.Activation",
			"System.Runtime.Remoting.Channels",
			"System.Runtime.Remoting.Channels.Http",
			"System.Runtime.Remoting.Channels.Ipc",
			"System.Runtime.Remoting.Channels.Tcp",
			"System.Runtime.Remoting.Contexts",
			"System.Runtime.Remoting.Lifetime",
			"System.Runtime.Remoting.Messaging",
			"System.Runtime.Remoting.Metadata",
			"System.Runtime.Remoting.Metadata.W3cXsd2001",
			"System.Runtime.Remoting.MetadataServices",
			"System.Runtime.Remoting.Proxies",
			"System.Runtime.Remoting.Services",
			"System.Runtime.Serialization",
			"System.Runtime.Serialization.Configuration",
			"System.Runtime.Serialization.Formatters",
			"System.Runtime.Serialization.Formatters.Binary",
			"System.Runtime.Serialization.Formatters.Soap",
			"System.Runtime.Serialization.Json",
			"System.Runtime.Versioning",
			"System.Runtime.InteropServices.CustomMarshalers",
			"System.Runtime.InteropServices.Automation",
			"System.Data",
			"System.Data.Common",
			"System.Data.Common.CommandTrees",
			"System.Data.Common.CommandTrees.ExpressionBuilder",
			"System.Data.Common.CommandTrees.ExpressionBuilder.Spatial",
			"System.Data.Common.EntitySql",
			"System.Data.Design",
			"System.Data.Entity.Design",
			"System.Data.Entity.Design.AspNet",
			"System.Data.Entity.Design.PluralizationServices",
			"System.Data.EntityClient",
			"System.Data.Linq",
			"System.Data.Linq.Mapping",
			"System.Data.Linq.SqlClient",
			"System.Data.Linq.SqlClient.Implementation",
			"System.Data.Mapping",
			"System.Data.Metadata.Edm",
			"System.Data.Objects",
			"System.Data.Objects.DataClasses",
			"System.Data.Objects.SqlClient",
			"System.Data.Odbc",
			"System.Data.OleDb",
			"System.Data.OracleClient",
			"System.Data.Services",
			"System.Data.Services.BuildProvider",
			"System.Data.Services.Client",
			"System.Data.Services.Common",
			"System.Data.Services.Configuration",
			"System.Data.Services.Design",
			"System.Data.Services.Internal",
			"System.Data.Services.Providers",
			"System.Data.Spatial",
			"System.Data.Sql",
			"System.Data.SqlClient",
			"System.Data.SqlTypes",
			"System.Activities",
			"System.Activities.Core.Presentation",
			"System.Activities.Core.Presentation.Factories",
			"System.Activities.Core.Presentation.Themes",
			"System.Activities.Debugger",
			"System.Activities.Debugger.Symbol",
			"System.Activities.DurableInstancing",
			"System.Activities.DynamicUpdate",
			"System.Activities.ExpressionParser",
			"System.Activities.Expressions",
			"System.Activities.Hosting",
			"System.Activities.Persistence",
			"System.Activities.Presentation",
			"System.Activities.Presentation.Annotations",
			"System.Activities.Presentation.Converters",
			"System.Activities.Presentation.Debug",
			"System.Activities.Presentation.Expressions",
			"System.Activities.Presentation.Hosting",
			"System.Activities.Presentation.Metadata",
			"System.Activities.Presentation.Model",
			"System.Activities.Presentation.PropertyEditing",
			"System.Activities.Presentation.Services",
			"System.Activities.Presentation.Sqm",
			"System.Activities.Presentation.Toolbox",
			"System.Activities.Presentation.Validation",
			"System.Activities.Presentation.View",
			"System.Activities.Presentation.View.OutlineView",
			"System.Activities.Presentation.ViewState",
			"System.Activities.Statements",
			"System.Activities.Statements.Tracking",
			"System.Activities.Tracking",
			"System.Activities.Validation",
			"System.Activities.XamlInteg",
			"System.Security",
			"System.Security.AccessControl",
			"System.Security.Authentication",
			"System.Security.Authentication.ExtendedProtection",
			"System.Security.Authentication.ExtendedProtection.Configuration",
			"System.Security.Claims",
			"System.Security.Cryptography",
			"System.Security.Cryptography.Pkcs",
			"System.Security.Cryptography.X509Certificates",
			"System.Security.Cryptography.Xml",
			"System.Security.Permissions",
			"System.Security.Policy",
			"System.Security.Principal",
			"System",
			"System.CodeDom.Compiler",
			"System.Collections",
			"System.Collections.Generic",
			"System.Collections.ObjectModel",
			"System.Collections.Specialized",
			"System.ComponentModel",
			"System.Configuration.Assemblies",
			"System.Diagnostics",
			"System.Diagnostics.CodeAnalysis",
			"System.Globalization",
			"System.IO",
			"System.Net",
			"System.Reflection",
			"System.Resources",
			"System.Runtime.CompilerServices",
			"System.Runtime.InteropServices",
			"System.Runtime.Serialization",
			"System.Security",
			"System.Security.Permissions",
			"System.Security.Policy",
			"System.Text",
			"System.Text.RegularExpressions",
			"System.Threading",
			"System.Xml",
			"System.Xml.Schema",
			"System.Xml.Serialization",
			"System.Xml.XPath",
			"System.Xml.Xsl",
			"System.Security.RightsManagement",
			"AppDomain.CreateDomain",
			"AppDomain.ExecuteAssembly",
			"AppDomain.ToString",
			"AppDomain.Unload ",
			"Array.BinarySearch",
			"Array.Clear",
			"Array.Clone",
			"Array.Copy",
			"Array.CopyTo",
			"Array.CreateInstance",
			"Array.GetEnumerator",
			"Array.GetLength",
			"Array.GetLowerBound",
			"Array.GetUpperBound",
			"Array.GetValue",
			"Array.IndexOf",
			"Array.Initialize",
			"Array.LastIndexOf",
			"Array.Resize<T>",
			"Array.Reverse",
			"Array.SetValue",
			"Array.Sort",
			"Array.TrueForAll<T> ",
			"ArraySegment<T>.Equals",
			"ArraySegment<T>.GetHashCode",
			"ArraySegment<T>.op_Equality",
			"ArraySegment<T>.op_Inequality ",
			"BitConverter.GetBytes",
			"BitConverter.ToBoolean",
			"BitConverter.ToChar",
			"BitConverter.ToDouble",
			"BitConverter.ToInt16",
			"BitConverter.ToInt32",
			"BitConverter.ToInt64",
			"BitConverter.ToSingle",
			"BitConverter.ToString",
			"BitConverter.ToUInt16",
			"BitConverter.ToUInt32",
			"BitConverter.ToUInt64 ",
			"Char.CompareTo",
			"Char.Equals",
			"Char.GetHashCode",
			"Char.GetNumericValue",
			"Char.GetTypeCode",
			"Char.GetUnicodeCategory",
			"Char.IsControl",
			"Char.IsDigit",
			"Char.IsLetter",
			"Char.IsLetterOrDigit",
			"Char.IsLower",
			"Char.IsNumber",
			"Char.IsPunctuation",
			"Char.IsSeparator",
			"Char.IsSurrogate",
			"Char.IsSurrogatePair",
			"Char.IsSymbol",
			"Char.IsUpper",
			"Char.IsWhiteSpace",
			"Char.ToLower",
			"Char.ToLowerInvariant",
			"Char.ToString",
			"Char.ToUpper ",
			"Convert.ChangeType",
			"Convert.FromBase64CharArray",
			"Convert.FromBase64String",
			"Convert.GetTypeCode",
			"Convert.IsDBNull",
			"Convert.ToBase64CharArray",
			"Convert.ToBase64String",
			"Convert.ToBoolean",
			"Convert.ToByte",
			"Convert.ToChar",
			"Convert.ToDateTime",
			"Convert.ToDecimal",
			"Convert.ToDouble",
			"Convert.ToInt16",
			"Convert.ToInt32",
			"Convert.ToInt64",
			"Convert.ToSByte",
			"Convert.ToSingle",
			"Convert.ToString",
			"Convert.ToUInt16",
			"Convert.ToUInt32",
			"Convert.ToUInt64 ",
			"DateTime.Add",
			"DateTime.AddDays",
			"DateTime.AddHours",
			"DateTime.AddMilliseconds",
			"DateTime.AddMinutes",
			"DateTime.AddMonths",
			"DateTime.AddSeconds",
			"DateTime.AddTicks",
			"DateTime.AddYears",
			"DateTime.Compare",
			"DateTime.CompareTo",
			"DateTime.DaysInMonth",
			"DateTime.Equals",
			"DateTime.FromFileTime",
			"DateTime.FromFileTimeUtc",
			"DateTime.FromOADate",
			"DateTime.GetDateTimeFormats",
			"DateTime.GetHashCode",
			"DateTime.GetTypeCode",
			"DateTime.IsDaylightSavingTime",
			"DateTime.IsLeapYear",
			"DateTime.op_Addition",
			"DateTime.op_Equality",
			"DateTime.op_GreaterThan",
			"DateTime.op_GreaterThanOrEqual",
			"DateTime.op_Inequality",
			"DateTime.op_LessThan",
			"DateTime.op_LessThanOrEqual",
			"DateTime.op_Subtraction",
			"DateTime.Parse",
			"DateTime.ParseExact",
			"DateTime.SpecifyKind",
			"DateTime.Subtract",
			"DateTime.ToFileTime",
			"DateTime.ToFileTimeUtc",
			"DateTime.ToLocalTime",
			"DateTime.ToLongDateString",
			"DateTime.ToLongTimeString",
			"DateTime.ToOADate",
			"DateTime.ToShortDateString",
			"DateTime.ToShortTimeString",
			"DateTime.ToString",
			"DateTime.ToUniversalTime ",
			"Decimal.Add",
			"Decimal.Compare",
			"Decimal.CompareTo",
			"Decimal.Divide",
			"Decimal.Equals",
			"Decimal.Floor",
			"Decimal.GetBits",
			"Decimal.GetHashCode",
			"Decimal.GetTypeCode",
			"Decimal.Multiply",
			"Decimal.Negate",
			"Decimal.op_Addition",
			"Decimal.op_Decrement",
			"Decimal.op_Division",
			"Decimal.op_Equality",
			"Decimal.op_Explicit",
			"Decimal.op_GreaterThan",
			"Decimal.op_GreaterThanOrEqual",
			"Decimal.op_Implicit",
			"Decimal.op_Increment",
			"Decimal.op_Inequality",
			"Decimal.op_LessThan",
			"Decimal.op_LessThanOrEqual",
			"Decimal.op_Modulus",
			"Decimal.op_Multiply",
			"Decimal.op_Subtraction",
			"Decimal.op_UnaryNegation",
			"Decimal.op_UnaryPlus",
			"Decimal.Parse",
			"Decimal.Remainder",
			"Decimal.Round",
			"Decimal.Subtract",
			"Decimal.ToByte",
			"Decimal.ToDouble",
			"Decimal.ToInt16",
			"Decimal.ToInt32",
			"Decimal.ToInt64",
			"Decimal.ToSByte",
			"Decimal.ToSingle",
			"Decimal.ToString",
			"Decimal.ToUInt16",
			"Decimal.ToUInt32",
			"Decimal.ToUInt64",
			"Decimal.Truncate ",
			"Double.CompareTo",
			"Double.Equals",
			"Double.GetHashCode",
			"Double.GetTypeCode",
			"Double.IsInfinity",
			"Double.IsNaN",
			"Double.IsNegativeInfinity",
			"Double.IsPositiveInfinity",
			"Double.Parse",
			"Double.ToString",
			"IConvertible.GetTypeCode",
			"IConvertible.ToBoolean",
			"IConvertible.ToByte",
			"IConvertible.ToChar",
			"IConvertible.ToDateTime",
			"IConvertible.ToDecimal",
			"IConvertible.ToDouble",
			"IConvertible.ToInt16",
			"IConvertible.ToInt32",
			"IConvertible.ToInt64",
			"IConvertible.ToSByte",
			"IConvertible.ToSingle",
			"IConvertible.ToString",
			"IConvertible.ToType",
			"IConvertible.ToUInt16",
			"IConvertible.ToUInt32",
			"IConvertible.ToUInt64 ",
			"Math.Abs",
			"Math.Acos",
			"Math.Asin",
			"Math.Atan",
			"Math.Atan2",
			"Math.Ceiling",
			"Math.Cos",
			"Math.Cosh",
			"Math.Exp",
			"Math.Floor",
			"Math.IEEERemainder",
			"Math.Log",
			"Math.Log10",
			"Math.Max",
			"Math.Min",
			"Math.Pow",
			"Math.Round",
			"Math.Sign",
			"Math.Sin",
			"Math.Sinh",
			"Math.Sqrt",
			"Math.Tan",
			"Math.Tanh ",
			"String.Clone",
			"String.Compare",
			"String.CompareOrdinal",
			"String.CompareTo",
			"String.Concat",
			"String.Contains",
			"String.Copy",
			"String.CopyTo",
			"String.EndsWith",
			"String.Equals",
			"String.Format",
			"String.GetEnumerator",
			"String.GetHashCode",
			"String.GetTypeCode",
			"String.IndexOf",
			"String.IndexOfAny",
			"String.Insert",
			"String.Intern",
			"String.IsInterned",
			"String.IsNullOrEmpty",
			"String.Join",
			"String.LastIndexOf",
			"String.LastIndexOfAny",
			"String.op_Equality",
			"String.op_Inequality",
			"String.PadLeft",
			"String.PadRight",
			"String.Remove",
			"String.Replace",
			"String.Split",
			"String.StartsWith",
			"String.Substring",
			"String.ToCharArray",
			"String.ToLower",
			"String.ToString",
			"String.ToUpper",
			"String.Trim",
			"String.TrimEnd",
			"String.TrimStart ",
			"TimeSpan.Add",
			"TimeSpan.Compare",
			"TimeSpan.CompareTo",
			"TimeSpan.Duration",
			"TimeSpan.Equals",
			"TimeSpan.FromDays",
			"TimeSpan.FromHours",
			"TimeSpan.FromMilliseconds",
			"TimeSpan.FromMinutes",
			"TimeSpan.FromSeconds",
			"TimeSpan.FromTicks",
			"TimeSpan.GetHashCode",
			"TimeSpan.Negate",
			"TimeSpan.op_Addition",
			"TimeSpan.op_Equality",
			"TimeSpan.op_GreaterThan",
			"TimeSpan.op_GreaterThanOrEqual",
			"TimeSpan.op_Inequality",
			"TimeSpan.op_LessThan",
			"TimeSpan.op_LessThanOrEqual",
			"TimeSpan.op_Subtraction",
			"TimeSpan.op_UnaryNegation",
			"TimeSpan.Parse",
			"TimeSpan.Subtract",
			"TimeSpan.ToString ",
			"Type.Equals",
			"Type.GetArrayRank",
			"Type.GetAttributeFlagsImpl",
			"Type.GetConstructor",
			"Type.GetConstructorImpl",
			"Type.GetConstructors",
			"Type.GetDefaultMembers",
			"Type.GetElementType",
			"Type.GetEvent",
			"Type.GetEvents",
			"Type.GetField",
			"Type.GetFields",
			"Type.GetGenericArguments",
			"Type.GetGenericTypeDefinition",
			"Type.GetHashCode",
			"Type.GetInterfaces",
			"Type.GetMember",
			"Type.GetMembers",
			"Type.GetMethod",
			"Type.GetMethodImpl",
			"Type.GetMethods",
			"Type.GetNestedType",
			"Type.GetNestedTypes",
			"Type.GetProperties",
			"Type.GetProperty",
			"Type.GetPropertyImpl",
			"Type.GetType",
			"Type.GetTypeCode",
			"Type.GetTypeFromHandle",
			"Type.HasElementTypeImpl",
			"Type.InvokeMember",
			"Type.IsArrayImpl",
			"Type.IsAssignableFrom",
			"Type.IsByRefImpl",
			"Type.IsCOMObjectImpl",
			"Type.IsInstanceOfType",
			"Type.IsPointerImpl",
			"Type.IsPrimitiveImpl",
			"Type.IsSubclassOf",
			"Type.IsValueTypeImpl",
			"Type.MakeGenericType",
			"Type.ToString ",
			"Type.Assembly",
			"Type.AssemblyQualifiedName",
			"Type.Attributes",
			"Type.BaseType",
			"Type.ContainsGenericParameters",
			"Type.DeclaringType",
			"Type.DefaultBinder",
			"Type.FullName",
			"Type.HasElementType",
			"Type.IsAbstract",
			"Type.IsAnsiClass",
			"Type.IsArray",
			"Type.IsAutoClass",
			"Type.IsAutoLayout",
			"Type.IsByRef",
			"Type.IsClass",
			"Type.IsCOMObject",
			"Type.IsEnum",
			"Type.IsGenericParameter",
			"Type.IsGenericType",
			"Type.IsGenericTypeDefinition",
			"Type.IsImport",
			"Type.IsInterface",
			"Type.IsNestedAssembly",
			"Type.IsNestedFamANDAssem",
			"Type.IsNestedFamily",
			"Type.IsNestedFamORAssem",
			"Type.IsNestedPrivate",
			"Type.IsNestedPublic",
			"Type.IsNotPublic",
			"Type.IsPointer",
			"Type.IsPrimitive",
			"Type.IsPublic",
			"Type.IsSealed",
			"Type.IsSpecialName",
			"Type.IsUnicodeClass",
			"Type.IsValueType",
			"Type.IsVisible",
			"Type.MemberType",
			"Type.Module",
			"Type.Namespace",
			"Type.ReflectedType",
			"Type.TypeHandle",
			"Type.UnderlyingSystemType ",
			"Uri.Canonicalize",
			"Uri.CheckHostName",
			"Uri.CheckSchemeName",
			"Uri.CheckSecurity",
			"Uri.Compare",
			"Uri.Equals",
			"Uri.Escape",
			"Uri.EscapeDataString",
			"Uri.EscapeString",
			"Uri.EscapeUriString",
			"Uri.FromHex",
			"Uri.GetComponents",
			"Uri.GetHashCode",
			"Uri.GetLeftPart",
			"Uri.HexEscape",
			"Uri.HexUnescape",
			"Uri.IsBadFileSystemCharacter",
			"Uri.IsBaseOf",
			"Uri.IsExcludedCharacter",
			"Uri.IsHexDigit",
			"Uri.IsHexEncoding",
			"Uri.IsReservedCharacter",
			"Uri.IsWellFormedOriginalString",
			"Uri.IsWellFormedUriString",
			"Uri.MakeRelative",
			"Uri.MakeRelativeUri",
			"Uri.op_Equality",
			"Uri.op_Inequality",
			"Uri.Parse",
			"Uri.ToString",
			"Uri.TryCreate",
			"Uri.Unescape",
			"Uri.UnescapeDataString ",
			"Version.Clone",
			"Version.CompareTo",
			"Version.Equals",
			"Version.GetHashCode",
			"Version.op_Equality",
			"Version.op_GreaterThan",
			"Version.op_GreaterThanOrEqual",
			"Version.op_Inequality",
			"Version.op_LessThan",
			"Version.op_LessThanOrEqual",
			"Version.ToString ",
			"ArrayList.Add",
			"ArrayList.AddRange",
			"ArrayList.BinarySearch",
			"ArrayList.Clear",
			"ArrayList.Clone",
			"ArrayList.Contains",
			"ArrayList.CopyTo",
			"ArrayList.GetEnumerator",
			"ArrayList.IndexOf",
			"ArrayList.Insert",
			"ArrayList.InsertRange",
			"ArrayList.Remove",
			"ArrayList.RemoveAt",
			"ArrayList.RemoveRange",
			"ArrayList.Reverse",
			"ArrayList.Sort",
			"ArrayList.Synchronized",
			"ArrayList.ToArray",
			"ArrayList.TrimToSize ",
			"BitArray.And",
			"BitArray.Clone",
			"BitArray.CopyTo",
			"BitArray.Get",
			"BitArray.GetEnumerator",
			"BitArray.Not",
			"BitArray.Or",
			"BitArray.Set",
			"BitArray.SetAll",
			"BitArray.Xor ",
			"Hashtable.Add",
			"Hashtable.Clear",
			"Hashtable.Clone",
			"Hashtable.Contains",
			"Hashtable.ContainsKey",
			"Hashtable.ContainsValue",
			"Hashtable.CopyTo",
			"Hashtable.GetEnumerator",
			"Hashtable.GetHash",
			"Hashtable.KeyEquals",
			"Hashtable.Remove",
			"Hashtable.Synchronized ",
			"Hashtable.comparer",
			"Hashtable.Count",
			"Hashtable.EqualityComparer",
			"Hashtable.hcp",
			"Hashtable.IsFixedSize",
			"Hashtable.IsReadOnly",
			"Hashtable.IsSynchronized",
			"Hashtable.Item",
			"Hashtable.Keys",
			"Hashtable.SyncRoot",
			"Hashtable.Values ",
			"SortedList.Clear",
			"SortedList.Clone",
			"SortedList.Contains",
			"SortedList.ContainsKey",
			"SortedList.ContainsValue",
			"SortedList.CopyTo",
			"SortedList.GetByIndex",
			"SortedList.GetEnumerator",
			"SortedList.GetKey",
			"SortedList.GetKeyList",
			"SortedList.GetValueList",
			"SortedList.IndexOfKey",
			"SortedList.IndexOfValue",
			"SortedList.Remove",
			"SortedList.RemoveAt",
			"SortedList.SetByIndex",
			"SortedList.Synchronized",
			"SortedList.TrimToSize ",
			"Dictionary<TKey><TValue>.Add",
			"Dictionary<TKey><TValue>.Clear",
			"Dictionary<TKey><TValue>.ContainsKey",
			"Dictionary<TKey><TValue>.ContainsValue",
			"Dictionary<TKey><TValue>.GetEnumerator",
			"Dictionary<TKey><TValue>.Remove",
			"Dictionary<TKey><TValue>.TryGetValue ",
			"LinkedList<T>.AddAfter",
			"LinkedList<T>.AddBefore",
			"LinkedList<T>.AddFirst",
			"LinkedList<T>.AddLast",
			"LinkedList<T>.Clear",
			"LinkedList<T>.Contains",
			"LinkedList<T>.CopyTo",
			"LinkedList<T>.Find",
			"LinkedList<T>.FindLast",
			"LinkedList<T>.GetEnumerator",
			"LinkedList<T>.Remove",
			"LinkedList<T>.RemoveFirst",
			"LinkedList<T>.RemoveLast ",
			"List<T>.Add",
			"List<T>.AddRange",
			"List<T>.AsReadOnly",
			"List<T>.BinarySearch",
			"List<T>.Clear",
			"List<T>.Contains",
			"List<T>.ConvertAll<TOutput>",
			"List<T>.CopyTo",
			"List<T>.Exists",
			"List<T>.Find",
			"List<T>.FindAll",
			"List<T>.FindIndex",
			"List<T>.FindLast",
			"List<T>.FindLastIndex",
			"List<T>.ForEach",
			"List<T>.GetEnumerator",
			"List<T>.GetRange",
			"List<T>.IndexOf",
			"List<T>.Insert",
			"List<T>.InsertRange",
			"List<T>.LastIndexOf",
			"List<T>.Remove",
			"List<T>.RemoveAll",
			"List<T>.RemoveAt",
			"List<T>.RemoveRange",
			"List<T>.Reverse",
			"List<T>.Sort",
			"List<T>.ToArray",
			"List<T>.TrimExcess",
			"List<T>.TrueForAll ",
			"SortedList<TKey><TValue>.Add",
			"SortedList<TKey><TValue>.Clear",
			"SortedList<TKey><TValue>.ContainsKey",
			"SortedList<TKey><TValue>.ContainsValue",
			"SortedList<TKey><TValue>.GetEnumerator",
			"SortedList<TKey><TValue>.IndexOfKey",
			"SortedList<TKey><TValue>.IndexOfValue",
			"SortedList<TKey><TValue>.Remove",
			"SortedList<TKey><TValue>.RemoveAt",
			"SortedList<TKey><TValue>.TrimExcess",
			"SortedList<TKey><TValue>.TryGetValue ",
			"NameObjectCollectionBase.BaseAdd",
			"NameObjectCollectionBase.BaseClear",
			"NameObjectCollectionBase.BaseGet",
			"NameObjectCollectionBase.BaseGetAllKeys",
			"NameObjectCollectionBase.BaseGetKey",
			"NameObjectCollectionBase.BaseHasKeys",
			"NameObjectCollectionBase.BaseRemove",
			"NameObjectCollectionBase.BaseRemoveAt",
			"NameObjectCollectionBase.BaseSet",
			"NameObjectCollectionBase.GetEnumerator ",
			"BindingList<T>.AddNew",
			"BindingList<T>.AddNewCore",
			"BindingList<T>.ApplySortCore",
			"BindingList<T>.CancelNew",
			"BindingList<T>.ClearItems",
			"BindingList<T>.EndNew",
			"BindingList<T>.FindCore",
			"BindingList<T>.InsertItem",
			"BindingList<T>.OnAddingNew",
			"BindingList<T>.OnListChanged",
			"BindingList<T>.RemoveItem",
			"BindingList<T>.RemoveSortCore",
			"BindingList<T>.ResetBindings",
			"BindingList<T>.ResetItem",
			"BindingList<T>.SetItem ",
			"PropertyDescriptorCollection.Add",
			"PropertyDescriptorCollection.Clear",
			"PropertyDescriptorCollection.Contains",
			"PropertyDescriptorCollection.CopyTo",
			"PropertyDescriptorCollection.Find",
			"PropertyDescriptorCollection.GetEnumerator",
			"PropertyDescriptorCollection.IndexOf",
			"PropertyDescriptorCollection.Insert",
			"PropertyDescriptorCollection.Remove",
			"PropertyDescriptorCollection.RemoveAt ",
			"Calendar.AddDays",
			"Calendar.AddHours",
			"Calendar.AddMilliseconds",
			"Calendar.AddMinutes",
			"Calendar.AddMonths",
			"Calendar.AddSeconds",
			"Calendar.AddWeeks",
			"Calendar.AddYears",
			"Calendar.GetDayOfMonth",
			"Calendar.GetDayOfWeek",
			"Calendar.GetDayOfYear",
			"Calendar.GetDaysInMonth",
			"Calendar.GetDaysInYear",
			"Calendar.GetEra",
			"Calendar.GetHour",
			"Calendar.GetMilliseconds",
			"Calendar.GetMinute",
			"Calendar.GetMonth",
			"Calendar.GetMonthsInYear",
			"Calendar.GetSecond",
			"Calendar.GetWeekOfYear",
			"Calendar.GetYear",
			"Calendar.IsLeapDay",
			"Calendar.IsLeapMonth",
			"Calendar.IsLeapYear",
			"Calendar.ToDateTime",
			"Calendar.ToFourDigitYear ",
			"CultureInfo.Calendar",
			"CultureInfo.CompareInfo",
			"CultureInfo.CurrentCulture",
			"CultureInfo.CurrentUICulture",
			"CultureInfo.DateTimeFormat",
			"CultureInfo.EnglishName",
			"CultureInfo.InvariantCulture",
			"CultureInfo.IsNeutralCulture",
			"CultureInfo.IsReadOnly",
			"CultureInfo.LCID",
			"CultureInfo.Name",
			"CultureInfo.NativeName",
			"CultureInfo.NumberFormat",
			"CultureInfo.OptionalCalendars",
			"CultureInfo.Parent",
			"CultureInfo.TextInfo",
			"CultureInfo.ThreeLetterISOLanguageName",
			"CultureInfo.ThreeLetterWindowsLanguageName",
			"CultureInfo.TwoLetterISOLanguageName",
			"CultureInfo.UseUserOverride ",
			"NumberFormatInfo.CurrencyDecimalDigits",
			"NumberFormatInfo.CurrencyDecimalSeparator",
			"NumberFormatInfo.CurrencyGroupSeparator",
			"NumberFormatInfo.CurrencyGroupSizes",
			"NumberFormatInfo.CurrencyNegativePattern",
			"NumberFormatInfo.CurrencyPositivePattern",
			"NumberFormatInfo.CurrencySymbol",
			"NumberFormatInfo.CurrentInfo",
			"NumberFormatInfo.InvariantInfo",
			"NumberFormatInfo.IsReadOnly",
			"NumberFormatInfo.NaNSymbol",
			"NumberFormatInfo.NegativeInfinitySymbol",
			"NumberFormatInfo.NegativeSign",
			"NumberFormatInfo.NumberDecimalDigits",
			"NumberFormatInfo.NumberDecimalSeparator",
			"NumberFormatInfo.NumberGroupSeparator",
			"NumberFormatInfo.NumberGroupSizes",
			"NumberFormatInfo.NumberNegativePattern",
			"NumberFormatInfo.PercentDecimalDigits",
			"NumberFormatInfo.PercentDecimalSeparator",
			"NumberFormatInfo.PercentGroupSeparator",
			"NumberFormatInfo.PercentGroupSizes",
			"NumberFormatInfo.PercentNegativePattern",
			"NumberFormatInfo.PercentPositivePattern",
			"NumberFormatInfo.PercentSymbol",
			"NumberFormatInfo.PerMilleSymbol",
			"NumberFormatInfo.PositiveInfinitySymbol",
			"NumberFormatInfo.PositiveSign ",
			"TaiwanCalendar.AddMonths",
			"TaiwanCalendar.AddYears",
			"TaiwanCalendar.GetDayOfMonth",
			"TaiwanCalendar.GetDayOfWeek",
			"TaiwanCalendar.GetDayOfYear",
			"TaiwanCalendar.GetDaysInMonth",
			"TaiwanCalendar.GetDaysInYear",
			"TaiwanCalendar.GetEra",
			"TaiwanCalendar.GetMonth",
			"TaiwanCalendar.GetMonthsInYear",
			"TaiwanCalendar.GetWeekOfYear",
			"TaiwanCalendar.GetYear",
			"TaiwanCalendar.IsLeapDay",
			"TaiwanCalendar.IsLeapMonth",
			"TaiwanCalendar.IsLeapYear",
			"TaiwanCalendar.ToDateTime",
			"TaiwanCalendar.ToFourDigitYear ",
			"BinaryReader.Close",
			"BinaryReader.Dispose",
			"BinaryReader.FillBuffer",
			"BinaryReader.PeekChar",
			"BinaryReader.Read",
			"BinaryReader.Read7BitEncodedInt",
			"BinaryReader.ReadBoolean",
			"BinaryReader.ReadByte",
			"BinaryReader.ReadBytes",
			"BinaryReader.ReadChar",
			"BinaryReader.ReadChars",
			"BinaryReader.ReadDouble",
			"BinaryReader.ReadInt16",
			"BinaryReader.ReadInt32",
			"BinaryReader.ReadInt64",
			"BinaryReader.ReadSByte",
			"BinaryReader.ReadSingle",
			"BinaryReader.ReadString",
			"BinaryReader.ReadUInt16",
			"BinaryReader.ReadUInt32",
			"BinaryReader.ReadUInt64 ",
			"MethodBase.Attributes",
			"MethodBase.CallingConvention",
			"MethodBase.ContainsGenericParameters",
			"MethodBase.IsAbstract",
			"MethodBase.IsAssembly",
			"MethodBase.IsConstructor",
			"MethodBase.IsFamily",
			"MethodBase.IsFamilyAndAssembly",
			"MethodBase.IsFamilyOrAssembly",
			"MethodBase.IsFinal",
			"MethodBase.IsGenericMethod",
			"MethodBase.IsGenericMethodDefinition",
			"MethodBase.IsHideBySig",
			"MethodBase.IsPrivate",
			"MethodBase.IsPublic",
			"MethodBase.IsSpecialName",
			"MethodBase.IsStatic",
			"MethodBase.IsVirtual",
			"MethodBase.MethodHandle ",
			"XmlNodeReader.Close",
			"XmlNodeReader.GetAttribute",
			"XmlNodeReader.LookupNamespace",
			"XmlNodeReader.MoveToAttribute",
			"XmlNodeReader.MoveToElement",
			"XmlNodeReader.MoveToFirstAttribute",
			"XmlNodeReader.MoveToNextAttribute",
			"XmlNodeReader.Read",
			"XmlNodeReader.ReadAttributeValue",
			"XmlNodeReader.ReadContentAsBase64",
			"XmlNodeReader.ReadContentAsBinHex",
			"XmlNodeReader.ReadElementContentAsBase64",
			"XmlNodeReader.ReadElementContentAsBinHex",
			"XmlNodeReader.ReadString",
			"XmlNodeReader.ResolveEntity",
			"XmlNodeReader.Skip ",
			"XmlNodeReader.AttributeCount",
			"XmlNodeReader.BaseURI",
			"XmlNodeReader.CanReadBinaryContent",
			"XmlNodeReader.Depth",
			"XmlNodeReader.EOF",
			"XmlNodeReader.HasAttributes",
			"XmlNodeReader.HasValue",
			"XmlNodeReader.IsDefault",
			"XmlNodeReader.IsEmptyElement",
			"XmlNodeReader.LocalName",
			"XmlNodeReader.Name",
			"XmlNodeReader.NamespaceURI",
			"XmlNodeReader.NameTable",
			"XmlNodeReader.NodeType",
			"XmlNodeReader.Prefix",
			"XmlNodeReader.ReadState",
			"XmlNodeReader.SchemaInfo",
			"XmlNodeReader.Value",
			"XmlNodeReader.XmlLang",
			"XmlNodeReader.XmlSpace ",
			"XmlReader.Close",
			"XmlReader.Create",
			"XmlReader.Dispose",
			"XmlReader.GetAttribute",
			"XmlReader.IsName",
			"XmlReader.IsNameToken",
			"XmlReader.IsStartElement",
			"XmlReader.LookupNamespace",
			"XmlReader.MoveToAttribute",
			"XmlReader.MoveToContent",
			"XmlReader.MoveToElement",
			"XmlReader.MoveToFirstAttribute",
			"XmlReader.MoveToNextAttribute",
			"XmlReader.Read",
			"XmlReader.ReadAttributeValue",
			"XmlReader.ReadContentAs",
			"XmlReader.ReadContentAsBase64",
			"XmlReader.ReadContentAsBinHex",
			"XmlReader.ReadContentAsBoolean",
			"XmlReader.ReadContentAsDateTime",
			"XmlReader.ReadContentAsDecimal",
			"XmlReader.ReadContentAsDouble",
			"XmlReader.ReadContentAsFloat",
			"XmlReader.ReadContentAsInt",
			"XmlReader.ReadContentAsLong",
			"XmlReader.ReadContentAsObject",
			"XmlReader.ReadContentAsString",
			"XmlReader.ReadElementContentAs",
			"XmlReader.ReadElementContentAsBase64",
			"XmlReader.ReadElementContentAsBinHex",
			"XmlReader.ReadElementContentAsBoolean",
			"XmlReader.ReadElementContentAsDateTime",
			"XmlReader.ReadElementContentAsDecimal",
			"XmlReader.ReadElementContentAsDouble",
			"XmlReader.ReadElementContentAsFloat",
			"XmlReader.ReadElementContentAsInt",
			"XmlReader.ReadElementContentAsLong",
			"XmlReader.ReadElementContentAsObject",
			"XmlReader.ReadElementContentAsString",
			"XmlReader.ReadElementString",
			"XmlReader.ReadEndElement",
			"XmlReader.ReadInnerXml",
			"XmlReader.ReadOuterXml",
			"XmlReader.ReadStartElement",
			"XmlReader.ReadString",
			"XmlReader.ReadSubtree",
			"XmlReader.ReadToDescendant",
			"XmlReader.ReadToFollowing",
			"XmlReader.ReadToNextSibling",
			"XmlReader.ReadValueChunk",
			"XmlReader.ResolveEntity",
			"XmlReader.Skip ",
			"XmlReader.AttributeCount",
			"XmlReader.BaseURI",
			"XmlReader.CanReadBinaryContent",
			"XmlReader.CanReadValueChunk",
			"XmlReader.CanResolveEntity",
			"XmlReader.Depth",
			"XmlReader.EOF",
			"XmlReader.HasAttributes",
			"XmlReader.HasValue",
			"XmlReader.IsDefault",
			"XmlReader.IsEmptyElement",
			"XmlReader.Item",
			"XmlReader.Item",
			"XmlReader.Item",
			"XmlReader.LocalName",
			"XmlReader.Name",
			"XmlReader.NamespaceURI",
			"XmlReader.NameTable",
			"XmlReader.NodeType",
			"XmlReader.Prefix",
			"XmlReader.QuoteChar",
			"XmlReader.ReadState",
			"XmlReader.SchemaInfo",
			"XmlReader.Settings",
			"XmlReader.Value",
			"XmlReader.ValueType",
			"XmlReader.XmlLang",
			"XmlReader.XmlSpace ",
			"XmlTextReader.Close",
			"XmlTextReader.GetAttribute",
			"XmlTextReader.GetNamespacesInScope",
			"XmlTextReader.GetRemainder",
			"XmlTextReader.HasLineInfo",
			"XmlTextReader.LookupNamespace",
			"XmlTextReader.MoveToAttribute",
			"XmlTextReader.MoveToElement",
			"XmlTextReader.MoveToFirstAttribute",
			"XmlTextReader.MoveToNextAttribute",
			"XmlTextReader.Read",
			"XmlTextReader.ReadAttributeValue",
			"XmlTextReader.ReadBase64",
			"XmlTextReader.ReadBinHex",
			"XmlTextReader.ReadChars",
			"XmlTextReader.ReadContentAsBase64",
			"XmlTextReader.ReadContentAsBinHex",
			"XmlTextReader.ReadElementContentAsBase64",
			"XmlTextReader.ReadElementContentAsBinHex",
			"XmlTextReader.ReadString",
			"XmlTextReader.ResetState",
			"XmlTextReader.ResolveEntity",
			"XmlTextReader.Skip ",
			"XmlTextReader.AttributeCount",
			"XmlTextReader.BaseURI",
			"XmlTextReader.CanReadBinaryContent",
			"XmlTextReader.CanReadValueChunk",
			"XmlTextReader.CanResolveEntity",
			"XmlTextReader.Depth",
			"XmlTextReader.Encoding",
			"XmlTextReader.EntityHandling",
			"XmlTextReader.EOF",
			"XmlTextReader.HasValue",
			"XmlTextReader.IsDefault",
			"XmlTextReader.IsEmptyElement",
			"XmlTextReader.LineNumber",
			"XmlTextReader.LinePosition",
			"XmlTextReader.LocalName",
			"XmlTextReader.Name",
			"XmlTextReader.Namespaces",
			"XmlTextReader.NamespaceURI",
			"XmlTextReader.NameTable",
			"XmlTextReader.NodeType",
			"XmlTextReader.Normalization",
			"XmlTextReader.Prefix",
			"XmlTextReader.QuoteChar",
			"XmlTextReader.ReadState",
			"XmlTextReader.Settings",
			"XmlTextReader.Value",
			"XmlTextReader.WhitespaceHandling",
			"XmlTextReader.XmlLang",
			"XmlTextReader.XmlResolver",
			"XmlTextReader.XmlSpace ",
			"XmlTextWriter.Close",
			"XmlTextWriter.Flush",
			"XmlTextWriter.LookupPrefix",
			"XmlTextWriter.WriteBase64",
			"XmlTextWriter.WriteBinHex",
			"XmlTextWriter.WriteCData",
			"XmlTextWriter.WriteCharEntity",
			"XmlTextWriter.WriteChars",
			"XmlTextWriter.WriteComment",
			"XmlTextWriter.WriteDocType",
			"XmlTextWriter.WriteEndAttribute",
			"XmlTextWriter.WriteEndDocument",
			"XmlTextWriter.WriteEndElement",
			"XmlTextWriter.WriteEntityRef",
			"XmlTextWriter.WriteFullEndElement",
			"XmlTextWriter.WriteName",
			"XmlTextWriter.WriteNmToken",
			"XmlTextWriter.WriteProcessingInstruction",
			"XmlTextWriter.WriteQualifiedName",
			"XmlTextWriter.WriteRaw",
			"XmlTextWriter.WriteStartAttribute",
			"XmlTextWriter.WriteStartDocument",
			"XmlTextWriter.WriteStartElement",
			"XmlTextWriter.WriteString",
			"XmlTextWriter.WriteSurrogateCharEntity",
			"XmlTextWriter.WriteWhitespace ",
			"XmlTextWriter.BaseStream",
			"XmlTextWriter.Formatting",
			"XmlTextWriter.Indentation",
			"XmlTextWriter.IndentChar",
			"XmlTextWriter.Namespaces",
			"XmlTextWriter.QuoteChar",
			"XmlTextWriter.WriteState",
			"XmlTextWriter.XmlLang",
			"XmlTextWriter.XmlSpace",
			"XmlWriter.Close",
			"XmlWriter.Create",
			"XmlWriter.Dispose",
			"XmlWriter.Flush",
			"XmlWriter.LookupPrefix",
			"XmlWriter.WriteAttributes",
			"XmlWriter.WriteAttributeString",
			"XmlWriter.WriteBase64",
			"XmlWriter.WriteBinHex",
			"XmlWriter.WriteCData",
			"XmlWriter.WriteCharEntity",
			"XmlWriter.WriteChars",
			"XmlWriter.WriteComment",
			"XmlWriter.WriteDocType",
			"XmlWriter.WriteElementString",
			"XmlWriter.WriteEndAttribute",
			"XmlWriter.WriteEndDocument",
			"XmlWriter.WriteEndElement",
			"XmlWriter.WriteEntityRef",
			"XmlWriter.WriteFullEndElement",
			"XmlWriter.WriteName",
			"XmlWriter.WriteNmToken",
			"XmlWriter.WriteNode",
			"XmlWriter.WriteProcessingInstruction",
			"XmlWriter.WriteQualifiedName",
			"XmlWriter.WriteRaw",
			"XmlWriter.WriteStartAttribute",
			"XmlWriter.WriteStartDocument",
			"XmlWriter.WriteStartElement",
			"XmlWriter.WriteString",
			"XmlWriter.WriteSurrogateCharEntity",
			"XmlWriter.WriteValue",
			"XmlWriter.WriteWhitespace "
		};
	}
}