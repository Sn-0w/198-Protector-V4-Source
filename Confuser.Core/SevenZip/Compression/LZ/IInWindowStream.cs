﻿using System;
using System.IO;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000011 RID: 17
	internal interface IInWindowStream
	{
		// Token: 0x0600003D RID: 61
		void SetStream(Stream inStream);

		// Token: 0x0600003E RID: 62
		void Init();

		// Token: 0x0600003F RID: 63
		void ReleaseStream();

		// Token: 0x06000040 RID: 64
		byte GetIndexByte(int index);

		// Token: 0x06000041 RID: 65
		uint GetMatchLen(int index, uint distance, uint limit);

		// Token: 0x06000042 RID: 66
		uint GetNumAvailableBytes();
	}
}
