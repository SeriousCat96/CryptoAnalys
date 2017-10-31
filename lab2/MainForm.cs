using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
	public partial class MainForm : Form
	{
		Feistel feistel;
		int rounds = 12;

		public MainForm()
		{
			InitializeComponent();
		}

		byte[] ConvertToByte(BitArray bits)
		{
			byte[] bytes = new byte[bits.Count / 8];
			bits.CopyTo(bytes, 0);
			return bytes;
		}

		private void OnButtonEncryptClick(object sender, EventArgs e)
		{
			var key = Encoding
				.Default
				.GetBytes(tbKey.Text);

			var inputText = rtbInput.Text;

			feistel = new Feistel(inputText, rounds, blockSize: 64);
			if(key.Length != feistel.BlockSize / 16)
			{
				MessageBox.Show(this, "Размер ключа не соответствует размеру блока!");
				return;
			}

			var encryptedText = feistel.Encrypt(key);

			rtbOutput.Text = encryptedText;
		}

		private void OnButtonDecryptClick(object sender, EventArgs e)
		{
			var key = Encoding
				.Default
				.GetBytes(tbKey.Text);

			if(key.Length != feistel.BlockSize / 16)
			{
				MessageBox.Show(this, "Размер ключа не соответствует размеру блока!");
				return;
			}

			var decryptedText = feistel.Decrypt(key);

			rtbOutput.Text = decryptedText;
		}
	}
}
