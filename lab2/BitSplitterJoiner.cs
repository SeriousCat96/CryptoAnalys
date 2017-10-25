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
		public static List<string> GetAllBits(string text, int blockSize = 64)
		{
			var bytes = Encoding
				.ASCII
				.GetBytes(text);

			var bitArray = new BitArray(bytes);

			//сколько блоков получается
			int blocksCount = (int)Math.Ceiling(bytes.Length / (double)blockSize);

			

			//содержит все биты и хвост дополнен 000000
			var finalArray = new byte[blocksCount * blockSize];

			bitArray.CopyTo(finalArray, 0);
			///TODO
			///ПРОВЕРИТЬ РАБОТУ, ДОПИСАТЬ!

			//Array.ConstrainedCopy(bitArray, 0, finalArray, 0, bitArray.Length);



				 
			//for(int i = 0; i < blocksCount; i++)
			//{
			//	var sb = new StringBuilder();

			//	for(int j = 0; j < blockSize; j++)
			//	{
			//		sb.Append(bitArray[i * blockSize + j] ? 1 : 0);
			//	}


			//}

			return null;
		}
	}
}
