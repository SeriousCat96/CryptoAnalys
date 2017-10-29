﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
	public static class BitSplitterJoiner
	{
		//возвращает писок из массивов, содержащих биты, по 64 в каждом.
		public static List<byte[]> GetBlocks(string text, int blockSize = 64)
		{
			int blockSizeInBytes = blockSize / 8;

			var bytesTmp = Encoding
				.ASCII
				.GetBytes(text);

			int blocksCount = (int)Math.Ceiling(bytesTmp.Length / (double)blockSizeInBytes);

			var bytes = new byte[blockSizeInBytes * blocksCount];

			Array.Copy(bytesTmp, bytes, bytesTmp.Length);
			//A - 65
			//76543210
			//01000001

			//B - 66
			//76543210
			//01000010

			//возвощаемое содержимое
			List<byte[]> finalList = new List<byte[]>();

			for (int i = 0; i < blocksCount; i++)
			{
				var tmp = new byte[blockSizeInBytes];
				Array.ConstrainedCopy(bytes, i * blockSizeInBytes, tmp, 0, blockSizeInBytes);
				finalList.Add(tmp);
			}			

			return finalList;
		}
	}
}
