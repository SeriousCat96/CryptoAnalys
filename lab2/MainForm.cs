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

		private void MainForm_Load(object sender, EventArgs e)
		{
			//byte[] ar_a = BitConverter.GetBytes('A');
			//byte[] ar_a = {1,0,0,0,0,0,1};
			//var a = BitConverter.ToBoolean(ar_a, 0);

			//var bytes = Encoding
			//.ASCII
			//.GetBytes("ABCDEFG");

			//var arr = new BitArray(bytes);
			//var sb = new StringBuilder();

			//foreach (var a in arr)
			//{
			//	sb.Append((bool)a ? 1 : 0);
			//}

			//MessageBox.Show(this, sb.ToString());

			//var str = Encoding
			//.ASCII
			//.GetString(ConvertToByte(arr));

			//MessageBox.Show(this, str);

			var res = BitSplitterJoiner.GetBlocks("it was pain!", 64);


			//s:RFRFvo

			var tmp_key = Encoding.ASCII.GetBytes("s:RFk");

			Feistel feistel = new Feistel(0, new byte[] {9,4}, "hhhhhhh");

			Feistel f = new Feistel(12, new byte[] { 129, 55, 78, 54 }, "something to encrypt!!!");

			var rrrrr = f.Encrypt();

			char[] dt = new char [rrrrr.Length];
			rrrrr.CopyTo(0, dt, 0, rrrrr.Length);


			var rrww = f.Decrypt(dt);


			var ssdfsd = new BitArray(new byte[] { 63 });






		}
	}
}
