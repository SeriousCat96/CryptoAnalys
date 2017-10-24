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
	public partial class MainForm : Form
	{
		Cypher _cypher;
		public MainForm()
		{
			InitializeComponent();

			_cypher = new Cypher();

			textBox1.Text = _cypher.ShowProbabilities();
			textBox2.Text = _cypher.Text;
			_cypher.DefaultDistribution();
			textBox3.Text = _cypher.ResultText;
			PrintLetters();
		}

		void PrintLetters()
		{
			foreach(var s in _cypher.LetterDict)
			{
				textBox4.Text += $"{ s.Key } - { s.Value }{ Environment.NewLine }";
			}
		}

		void ReplaceSymbols()
		{
			using(var window = new ChangeForm())
			{
				switch(window.ShowDialog())
				{
					case DialogResult.OK:
						{
							// TODO: Взять данные из формы и поменять буквы
							break;
						}
					case DialogResult.Cancel:
						{
							break;
						}
				}
			}

			PrintLetters();
		}
	}
}
