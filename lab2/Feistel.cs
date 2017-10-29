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

		public readonly int BlockSize;

		public int IterNum { get; set; }
		public byte[] Key { get; set; }
		public string OriginalText { get; set; }
		public string EncryptedText { get; set; }

		/// <summary>
		/// Создает объект <see cref="Feistel"/>.
		/// </summary>
		/// <param name="iterNum">Количество итераций</param>
		/// <param name="key">Ключ шифрования</param>
		/// <param name="inputText">Исходный текст</param>
		public Feistel(string inputText, int iterNum, int blockSize)
		{
			IterNum = iterNum;
			OriginalText = inputText;
			BlockSize = blockSize;

			Init();

		}

		private void Init()
		{
			AllEncodingBlocks = BitSplitterJoiner.GetBlocks(OriginalText, 64);
		}

		public string Encrypt(byte[] key)
		{
			Key = key;
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
			}

			int v = sb.Length;
			EncryptedText = sb.ToString();
			return EncryptedText;

		}

		public string Decrypt(byte[] key)
		{
			Key = key;
			AllEncodingBlocks = BitSplitterJoiner.GetBlocks(EncryptedText);

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
					Tmp_Block = XoR(L_Block, Func(R_Block));

					L_Block = R_Block;
					R_Block = Tmp_Block;
				}

				var l = Encoding.ASCII.GetString(L_Block);
				var r = Encoding.ASCII.GetString(R_Block);

				string result = l + r;

				sb.Append(result);
			}

			return sb.ToString();
		}

		private byte[] Func(byte [] a)
		{
			byte[] result = new byte[a.Length];

			var bitArr = new BitArray(a);

			for (int i=0; i<a.Length; i++)
			{
				result[i] = (byte)(((a[i] + Key[i] >> 1) % 128));
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
