using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
	public partial class ChangeForm : Form
	{
		public string SymbolFrom
		{
			get
			{
				return textBox1.Text;
			}
			set
			{
				textBox1.Text = value;
			}
		}

		public string SymbolTo
		{
			get
			{
				return textBox2.Text;
			}
			set
			{
				textBox2.Text = value;
			}
		}

		public ChangeForm()
		{
			InitializeComponent();
		}
	}
}
