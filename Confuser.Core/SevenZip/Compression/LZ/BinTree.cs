﻿using System;
using System.IO;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000013 RID: 19
	internal class BinTree : InWindow, IMatchFinder, IInWindowStream
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002255 File Offset: 0x00000455
		public new void SetStream(Stream stream)
		{
			base.SetStream(stream);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002260 File Offset: 0x00000460
		public new void ReleaseStream()
		{
			base.ReleaseStream();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000048C0 File Offset: 0x00002AC0
		public new void Init()
		{
			base.Init();
			for (uint num = 0U; num < this._hashSizeSum; num += 1U)
			{
				this._hash[(int)num] = 0U;
			}
			this._cyclicBufferPos = 0U;
			base.ReduceOffsets(-1);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004904 File Offset: 0x00002B04
		public new byte GetIndexByte(int index)
		{
			return base.GetIndexByte(index);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004920 File Offset: 0x00002B20
		public new uint GetMatchLen(int index, uint distance, uint limit)
		{
			return base.GetMatchLen(index, distance, limit);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000493C File Offset: 0x00002B3C
		public new uint GetNumAvailableBytes()
		{
			return base.GetNumAvailableBytes();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004954 File Offset: 0x00002B54
		public void Create(uint historySize, uint keepAddBufferBefore, uint matchMaxLen, uint keepAddBufferAfter)
		{
			bool flag = historySize > 2147483391U;
			if (flag)
			{
				throw new Exception();
			}
			this._cutValue = 16U + (matchMaxLen >> 1);
			uint keepSizeReserv = (historySize + keepAddBufferBefore + matchMaxLen + keepAddBufferAfter) / 2U + 256U;
			base.Create(historySize + keepAddBufferBefore, matchMaxLen + keepAddBufferAfter, keepSizeReserv);
			this._matchMaxLen = matchMaxLen;
			uint num = historySize + 1U;
			bool flag2 = this._cyclicBufferSize != num;
			if (flag2)
			{
				this._son = new uint[(this._cyclicBufferSize = num) * 2U];
			}
			uint num2 = 65536U;
			bool hash_ARRAY = this.HASH_ARRAY;
			if (hash_ARRAY)
			{
				num2 = historySize - 1U;
				num2 |= num2 >> 1;
				num2 |= num2 >> 2;
				num2 |= num2 >> 4;
				num2 |= num2 >> 8;
				num2 >>= 1;
				num2 |= 65535U;
				bool flag3 = num2 > 16777216U;
				if (flag3)
				{
					num2 >>= 1;
				}
				this._hashMask = num2;
				num2 += 1U;
				num2 += this.kFixHashSize;
			}
			bool flag4 = num2 != this._hashSizeSum;
			if (flag4)
			{
				this._hash = new uint[this._hashSizeSum = num2];
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004A64 File Offset: 0x00002C64
		public uint GetMatches(uint[] distances)
		{
			bool flag = this._pos + this._matchMaxLen <= this._streamPos;
			uint num;
			if (flag)
			{
				num = this._matchMaxLen;
			}
			else
			{
				num = this._streamPos - this._pos;
				bool flag2 = num < this.kMinMatchCheck;
				if (flag2)
				{
					this.MovePos();
					return 0U;
				}
			}
			uint num2 = 0U;
			uint num3 = (this._pos > this._cyclicBufferSize) ? (this._pos - this._cyclicBufferSize) : 0U;
			uint num4 = this._bufferOffset + this._pos;
			uint num5 = 1U;
			uint num6 = 0U;
			uint num7 = 0U;
			bool hash_ARRAY = this.HASH_ARRAY;
			uint num9;
			if (hash_ARRAY)
			{
				uint num8 = CRC.Table[(int)this._bufferBase[(int)num4]] ^ (uint)this._bufferBase[(int)(num4 + 1U)];
				num6 = (num8 & 1023U);
				num8 ^= (uint)((uint)this._bufferBase[(int)(num4 + 2U)] << 8);
				num7 = (num8 & 65535U);
				num9 = ((num8 ^ CRC.Table[(int)this._bufferBase[(int)(num4 + 3U)]] << 5) & this._hashMask);
			}
			else
			{
				num9 = (uint)((int)this._bufferBase[(int)num4] ^ (int)this._bufferBase[(int)(num4 + 1U)] << 8);
			}
			uint num10 = this._hash[(int)(this.kFixHashSize + num9)];
			bool hash_ARRAY2 = this.HASH_ARRAY;
			if (hash_ARRAY2)
			{
				uint num11 = this._hash[(int)num6];
				uint num12 = this._hash[(int)(1024U + num7)];
				this._hash[(int)num6] = this._pos;
				this._hash[(int)(1024U + num7)] = this._pos;
				bool flag3 = num11 > num3;
				if (flag3)
				{
					bool flag4 = this._bufferBase[(int)(this._bufferOffset + num11)] == this._bufferBase[(int)num4];
					if (flag4)
					{
						num5 = (distances[(int)num2++] = 2U);
						distances[(int)num2++] = this._pos - num11 - 1U;
					}
				}
				bool flag5 = num12 > num3;
				if (flag5)
				{
					bool flag6 = this._bufferBase[(int)(this._bufferOffset + num12)] == this._bufferBase[(int)num4];
					if (flag6)
					{
						bool flag7 = num12 == num11;
						if (flag7)
						{
							num2 -= 2U;
						}
						num5 = (distances[(int)num2++] = 3U);
						distances[(int)num2++] = this._pos - num12 - 1U;
						num11 = num12;
					}
				}
				bool flag8 = num2 != 0U && num11 == num10;
				if (flag8)
				{
					num2 -= 2U;
					num5 = 1U;
				}
			}
			this._hash[(int)(this.kFixHashSize + num9)] = this._pos;
			uint num13 = (this._cyclicBufferPos << 1) + 1U;
			uint num14 = this._cyclicBufferPos << 1;
			uint val2;
			uint val = val2 = this.kNumHashDirectBytes;
			bool flag9 = this.kNumHashDirectBytes > 0U;
			if (flag9)
			{
				bool flag10 = num10 > num3;
				if (flag10)
				{
					bool flag11 = this._bufferBase[(int)(this._bufferOffset + num10 + this.kNumHashDirectBytes)] != this._bufferBase[(int)(num4 + this.kNumHashDirectBytes)];
					if (flag11)
					{
						num5 = (distances[(int)num2++] = this.kNumHashDirectBytes);
						distances[(int)num2++] = this._pos - num10 - 1U;
					}
				}
			}
			uint cutValue = this._cutValue;
			uint num16;
			for (;;)
			{
				bool flag12 = num10 <= num3 || cutValue-- == 0U;
				if (flag12)
				{
					break;
				}
				uint num15 = this._pos - num10;
				num16 = ((num15 <= this._cyclicBufferPos) ? (this._cyclicBufferPos - num15) : (this._cyclicBufferPos - num15 + this._cyclicBufferSize)) << 1;
				uint num17 = this._bufferOffset + num10;
				uint num18 = Math.Min(val2, val);
				bool flag13 = this._bufferBase[(int)(num17 + num18)] == this._bufferBase[(int)(num4 + num18)];
				if (flag13)
				{
					while ((num18 += 1U) != num)
					{
						bool flag14 = this._bufferBase[(int)(num17 + num18)] != this._bufferBase[(int)(num4 + num18)];
						if (flag14)
						{
							break;
						}
					}
					bool flag15 = num5 < num18;
					if (flag15)
					{
						num5 = (distances[(int)num2++] = num18);
						distances[(int)num2++] = num15 - 1U;
						bool flag16 = num18 == num;
						if (flag16)
						{
							goto Block_22;
						}
					}
				}
				bool flag17 = this._bufferBase[(int)(num17 + num18)] < this._bufferBase[(int)(num4 + num18)];
				if (flag17)
				{
					this._son[(int)num14] = num10;
					num14 = num16 + 1U;
					num10 = this._son[(int)num14];
					val = num18;
				}
				else
				{
					this._son[(int)num13] = num10;
					num13 = num16;
					num10 = this._son[(int)num13];
					val2 = num18;
				}
			}
			this._son[(int)num13] = (this._son[(int)num14] = 0U);
			goto IL_494;
			Block_22:
			this._son[(int)num14] = this._son[(int)num16];
			this._son[(int)num13] = this._son[(int)(num16 + 1U)];
			IL_494:
			this.MovePos();
			return num2;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004F14 File Offset: 0x00003114
		public void Skip(uint num)
		{
			for (;;)
			{
				bool flag = this._pos + this._matchMaxLen <= this._streamPos;
				uint num2;
				if (flag)
				{
					num2 = this._matchMaxLen;
					goto IL_55;
				}
				num2 = this._streamPos - this._pos;
				bool flag2 = num2 < this.kMinMatchCheck;
				if (!flag2)
				{
					goto IL_55;
				}
				this.MovePos();
				IL_303:
				if ((num -= 1U) <= 0U)
				{
					break;
				}
				continue;
				IL_55:
				uint num3 = (this._pos > this._cyclicBufferSize) ? (this._pos - this._cyclicBufferSize) : 0U;
				uint num4 = this._bufferOffset + this._pos;
				bool hash_ARRAY = this.HASH_ARRAY;
				uint num8;
				if (hash_ARRAY)
				{
					uint num5 = CRC.Table[(int)this._bufferBase[(int)num4]] ^ (uint)this._bufferBase[(int)(num4 + 1U)];
					uint num6 = num5 & 1023U;
					this._hash[(int)num6] = this._pos;
					num5 ^= (uint)((uint)this._bufferBase[(int)(num4 + 2U)] << 8);
					uint num7 = num5 & 65535U;
					this._hash[(int)(1024U + num7)] = this._pos;
					num8 = ((num5 ^ CRC.Table[(int)this._bufferBase[(int)(num4 + 3U)]] << 5) & this._hashMask);
				}
				else
				{
					num8 = (uint)((int)this._bufferBase[(int)num4] ^ (int)this._bufferBase[(int)(num4 + 1U)] << 8);
				}
				uint num9 = this._hash[(int)(this.kFixHashSize + num8)];
				this._hash[(int)(this.kFixHashSize + num8)] = this._pos;
				uint num10 = (this._cyclicBufferPos << 1) + 1U;
				uint num11 = this._cyclicBufferPos << 1;
				uint val2;
				uint val = val2 = this.kNumHashDirectBytes;
				uint cutValue = this._cutValue;
				uint num13;
				for (;;)
				{
					bool flag3 = num9 <= num3 || cutValue-- == 0U;
					if (flag3)
					{
						goto Block_5;
					}
					uint num12 = this._pos - num9;
					num13 = ((num12 <= this._cyclicBufferPos) ? (this._cyclicBufferPos - num12) : (this._cyclicBufferPos - num12 + this._cyclicBufferSize)) << 1;
					uint num14 = this._bufferOffset + num9;
					uint num15 = Math.Min(val2, val);
					bool flag4 = this._bufferBase[(int)(num14 + num15)] == this._bufferBase[(int)(num4 + num15)];
					if (flag4)
					{
						while ((num15 += 1U) != num2)
						{
							bool flag5 = this._bufferBase[(int)(num14 + num15)] != this._bufferBase[(int)(num4 + num15)];
							if (flag5)
							{
								break;
							}
						}
						bool flag6 = num15 == num2;
						if (flag6)
						{
							goto Block_9;
						}
					}
					bool flag7 = this._bufferBase[(int)(num14 + num15)] < this._bufferBase[(int)(num4 + num15)];
					if (flag7)
					{
						this._son[(int)num11] = num9;
						num11 = num13 + 1U;
						num9 = this._son[(int)num11];
						val = num15;
					}
					else
					{
						this._son[(int)num10] = num9;
						num10 = num13;
						num9 = this._son[(int)num10];
						val2 = num15;
					}
				}
				IL_2FB:
				this.MovePos();
				goto IL_303;
				Block_9:
				this._son[(int)num11] = this._son[(int)num13];
				this._son[(int)num10] = this._son[(int)(num13 + 1U)];
				goto IL_2FB;
				Block_5:
				this._son[(int)num10] = (this._son[(int)num11] = 0U);
				goto IL_2FB;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005238 File Offset: 0x00003438
		public void SetType(int numHashBytes)
		{
			this.HASH_ARRAY = (numHashBytes > 2);
			bool hash_ARRAY = this.HASH_ARRAY;
			if (hash_ARRAY)
			{
				this.kNumHashDirectBytes = 0U;
				this.kMinMatchCheck = 4U;
				this.kFixHashSize = 66560U;
			}
			else
			{
				this.kNumHashDirectBytes = 2U;
				this.kMinMatchCheck = 3U;
				this.kFixHashSize = 0U;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005290 File Offset: 0x00003490
		public new void MovePos()
		{
			uint num = this._cyclicBufferPos + 1U;
			this._cyclicBufferPos = num;
			bool flag = num >= this._cyclicBufferSize;
			if (flag)
			{
				this._cyclicBufferPos = 0U;
			}
			base.MovePos();
			bool flag2 = this._pos == 2147483647U;
			if (flag2)
			{
				this.Normalize();
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000052E4 File Offset: 0x000034E4
		private void NormalizeLinks(uint[] items, uint numItems, uint subValue)
		{
			for (uint num = 0U; num < numItems; num += 1U)
			{
				uint num2 = items[(int)num];
				bool flag = num2 <= subValue;
				if (flag)
				{
					num2 = 0U;
				}
				else
				{
					num2 -= subValue;
				}
				items[(int)num] = num2;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005320 File Offset: 0x00003520
		private void Normalize()
		{
			uint subValue = this._pos - this._cyclicBufferSize;
			this.NormalizeLinks(this._son, this._cyclicBufferSize * 2U, subValue);
			this.NormalizeLinks(this._hash, this._hashSizeSum, subValue);
			base.ReduceOffsets((int)subValue);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000226A File Offset: 0x0000046A
		public void SetCutValue(uint cutValue)
		{
			this._cutValue = cutValue;
		}

		// Token: 0x0400002D RID: 45
		private const uint kHash2Size = 1024U;

		// Token: 0x0400002E RID: 46
		private const uint kHash3Size = 65536U;

		// Token: 0x0400002F RID: 47
		private const uint kBT2HashSize = 65536U;

		// Token: 0x04000030 RID: 48
		private const uint kStartMaxLen = 1U;

		// Token: 0x04000031 RID: 49
		private const uint kHash3Offset = 1024U;

		// Token: 0x04000032 RID: 50
		private const uint kEmptyHashValue = 0U;

		// Token: 0x04000033 RID: 51
		private const uint kMaxValForNormalize = 2147483647U;

		// Token: 0x04000034 RID: 52
		private bool HASH_ARRAY = true;

		// Token: 0x04000035 RID: 53
		private uint _cutValue = 255U;

		// Token: 0x04000036 RID: 54
		private uint _cyclicBufferPos;

		// Token: 0x04000037 RID: 55
		private uint _cyclicBufferSize;

		// Token: 0x04000038 RID: 56
		private uint[] _hash;

		// Token: 0x04000039 RID: 57
		private uint _hashMask;

		// Token: 0x0400003A RID: 58
		private uint _hashSizeSum;

		// Token: 0x0400003B RID: 59
		private uint _matchMaxLen;

		// Token: 0x0400003C RID: 60
		private uint[] _son;

		// Token: 0x0400003D RID: 61
		private uint kFixHashSize = 66560U;

		// Token: 0x0400003E RID: 62
		private uint kMinMatchCheck = 4U;

		// Token: 0x0400003F RID: 63
		private uint kNumHashDirectBytes;
	}
}
