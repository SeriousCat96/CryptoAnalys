using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
	public class Feistel
	{

		private byte[] L_Block;
		private byte[] R_Block;

		public int IterNum { get; set; }
		public byte[] Key { get; set; }
		public string OriginalText { get; set; }

		/// <summary>
		/// Создает объект <see cref="Feistel"/>.
		/// </summary>
		/// <param name="iterNum">Количество итераций</param>
		/// <param name="key">Ключ шифрования</param>
		/// <param name="inputText">Исходный текст</param>
		public Feistel(int iterNum, byte[] key, string inputText)
		{
			IterNum = IterNum;
			this.Key = key;
			this.OriginalText = inputText;
			

		}

		private void Init()
		{

		}

		public void Encrypt()
		{
			
		}

		public void Decrypt()
		{

		}


	}
}
