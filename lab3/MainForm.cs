using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
	public partial class MainForm : Form
	{
		HashAlgorithm hashAlg;

		public MainForm()
		{
			InitializeComponent();

			hashAlg = new HashAlgorithm();
		}

		private void OnButtonHashClick(object sender, EventArgs e)
		{
			var h = hashAlg.Hash(tb1.Text);
			var sb = new StringBuilder();
			
			for(int i = 0; i < h.Length; i++)
			{
				sb.Append($"h[{i}] = {h[i]}{Environment.NewLine}");
			}

			var sum = new List<byte>(h).Select(s => (int)s).Sum();
			var codeStr = Encoding.Default.GetString(h);
			sb.Append($"Sum = {sum}{Environment.NewLine}");
			sb.Append($"Hash code: {codeStr}");

			rtb1.Text = sb.ToString();
		}
	}
}
