using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
	public class Feistel
	{
		private List<byte[]> AllEncodingBlocks;

		public int IterNum { get; set; }
		public byte[] Key { get; set; }
		public long KeyInt { get; set; }
		public string OriginalText { get; set; }

		public string DecryptedText { get; set; }

		/// <summary>
		/// Создает объект <see cref="Feistel"/>.
		/// </summary>
		/// <param name="iterNum">Количество итераций</param>
		/// <param name="key">Ключ шифрования</param>
		/// <param name="inputText">Исходный текст</param>
		public Feistel(int iterNum, byte[] key, string inputText)
		{
			IterNum = iterNum;
			this.Key = key;
			this.OriginalText = inputText;

			BuildKey();
			Init();

		}

		private void Init()
		{
			AllEncodingBlocks = BitSplitterJoiner.GetBlocks(OriginalText, 64);
		}

		public string Encrypt()
		{
			var sb = new StringBuilder();

			foreach(var block in AllEncodingBlocks)
			{
				var L_Block = new byte[block.Length / 2];
				var R_Block = new byte[block.Length / 2];
				var Tmp_Block = new byte[block.Length / 2];

				Array.ConstrainedCopy(block, 0, L_Block, 0, block.Length / 2);
				Array.ConstrainedCopy(block, block.Length/2, R_Block, 0, block.Length / 2);


				for (int i = 0; i<IterNum; i++)
				{
					Tmp_Block = XoR(R_Block, Func(L_Block));

					R_Block = L_Block;
					L_Block = Tmp_Block;
				}

				var l = Encoding.ASCII.GetString(L_Block);
				var r = Encoding.ASCII.GetString(R_Block);

				string result = l + r;

				sb.Append(result);

				//temp = *right ^ f(*left, key[i]);
				//*right = *left;
				//*left = temp;
			}

			int v = sb.Length;
			DecryptedText = sb.ToString();
			return DecryptedText;

		}

		public string Decrypt(char[] str)
		{
			AllEncodingBlocks = BitSplitterJoiner.GetBlocks(str.ToString());

			var sb = new StringBuilder();

			foreach(var block in AllEncodingBlocks)
			{
				var L_Block = new byte[block.Length / 2];
				var R_Block = new byte[block.Length / 2];
				var Tmp_Block = new byte[block.Length / 2];

				Array.ConstrainedCopy(block, 0, L_Block, 0, block.Length / 2);
				Array.ConstrainedCopy(block, block.Length / 2, R_Block, 0, block.Length / 2);


				for(int i = 0; i < IterNum; i++)
				{
					L_Block = XoR(L_Block, Func(R_Block));
					Tmp_Block = R_Block;

					R_Block = L_Block;
					L_Block = Tmp_Block;
				}

				var l = Encoding.ASCII.GetString(L_Block);
				var r = Encoding.ASCII.GetString(R_Block);

				string result = l + r;

				sb.Append(result);

				//temp = *right ^ f(*left, key[i]);
				//*right = *left;
				//*left = temp;
			}

			int v = sb.Length;


			return sb.ToString();
		}

		private void BuildKey()
		{
			long buildedKey = 0;
			for(int i = 0; i < Key.Length; i++)
			{
				buildedKey += Key[i] << (8 * i);
			}

			KeyInt = buildedKey;
		}

		private byte[] Func(byte [] a)
		{
			byte[] result = new byte[a.Length];

			var bitArr = new BitArray(a);

			for (int i=0; i<a.Length; i++)
			{
				//result[i] = (byte)(((a[i] + Key[i] >> 1) % 128));
				result[i] = (byte)(((a[i] % Key[i] )));
			}
			return result;

		}

		private byte[] XoR(byte[] a, byte[] b)
		{
			byte[] result = new byte[a.Length];

			for(int i=0; i<result.Length; i++)
			{
				result[i] = (byte)(a[i] ^ b[i]);
			}
			return result;

		}
	}
}
