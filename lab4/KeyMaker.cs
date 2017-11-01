using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
	public static class KeyMaker
	{
		static int[] tablePos = { 5, 11, 6, 8,    3, 13, 9, 7,    10, 4, 12, 2,    15, 1, 0, 14 };

		static BitArray[] result;

		public static void Swapping(ref BitArray a)
		{
			BitArray tmp = new BitArray(a);

			for(int i = 0; i<tablePos.Length; i++)
			{
				a[i] = tmp[tablePos[i]];
			}
		}

		public static BitArray Norm1(BitArray a)
		{
			var bitArr = new BitArray(a.Length);

			for(int j = 0; j<4; j++)
			{
				for(int i = 0; i < a.Length; i += 4)
				{
					bitArr[i+j] = a[i+j];
					Swapping(ref a);

				}
			}
			
			return bitArr;
		}

		public static BitArray[] ReturnKey(BitArray[] blockContainer)
		{
			result = new BitArray[blockContainer.Length];

			for(int i = 0; i < result.Length; i++)
			{
				result[i] = new BitArray(16);
			}


			for(int i = 0; i < result.Length; i++)
			{
				result[i] =  Norm1(blockContainer[i]);
			}



			return result;
		}
	}
}
