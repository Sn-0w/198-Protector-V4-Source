﻿using System;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x0200000D RID: 13
	internal struct BitEncoder
	{
		// Token: 0x06000026 RID: 38 RVA: 0x0000423C File Offset: 0x0000243C
		static BitEncoder()
		{
			for (int i = 8; i >= 0; i--)
			{
				uint num = 1U << 9 - i - 1;
				uint num2 = 1U << 9 - i;
				for (uint num3 = num; num3 < num2; num3 += 1U)
				{
					BitEncoder.ProbPrices[(int)num3] = (uint)((i << 6) + (int)(num2 - num3 << 6 >> 9 - i - 1));
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002203 File Offset: 0x00000403
		public void Init()
		{
			this.Prob = 1024U;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000042B4 File Offset: 0x000024B4
		public void UpdateModel(uint symbol)
		{
			bool flag = symbol == 0U;
			if (flag)
			{
				this.Prob += 2048U - this.Prob >> 5;
			}
			else
			{
				this.Prob -= this.Prob >> 5;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000042FC File Offset: 0x000024FC
		public void Encode(Encoder encoder, uint symbol)
		{
			uint num = (encoder.Range >> 11) * this.Prob;
			bool flag = symbol == 0U;
			if (flag)
			{
				encoder.Range = num;
				this.Prob += 2048U - this.Prob >> 5;
			}
			else
			{
				encoder.Low += (ulong)num;
				encoder.Range -= num;
				this.Prob -= this.Prob >> 5;
			}
			bool flag2 = encoder.Range < 16777216U;
			if (flag2)
			{
				encoder.Range <<= 8;
				encoder.ShiftLow();
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000043A8 File Offset: 0x000025A8
		public uint GetPrice(uint symbol)
		{
			return BitEncoder.ProbPrices[(int)(checked((IntPtr)((unchecked((ulong)(this.Prob - symbol) ^ (ulong)((long)(-(long)symbol))) & 2047UL) >> 2)))];
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000043D8 File Offset: 0x000025D8
		public uint GetPrice0()
		{
			return BitEncoder.ProbPrices[(int)(this.Prob >> 2)];
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000043F8 File Offset: 0x000025F8
		public uint GetPrice1()
		{
			return BitEncoder.ProbPrices[(int)(2048U - this.Prob >> 2)];
		}

		// Token: 0x0400001E RID: 30
		public const int kNumBitModelTotalBits = 11;

		// Token: 0x0400001F RID: 31
		public const uint kBitModelTotal = 2048U;

		// Token: 0x04000020 RID: 32
		private const int kNumMoveBits = 5;

		// Token: 0x04000021 RID: 33
		private const int kNumMoveReducingBits = 2;

		// Token: 0x04000022 RID: 34
		public const int kNumBitPriceShiftBits = 6;

		// Token: 0x04000023 RID: 35
		private static readonly uint[] ProbPrices = new uint[512];

		// Token: 0x04000024 RID: 36
		private uint Prob;
	}
}
