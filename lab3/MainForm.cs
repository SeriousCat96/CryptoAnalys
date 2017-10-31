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
			var output = hashAlg.Hash("123");


		}
	}
}
