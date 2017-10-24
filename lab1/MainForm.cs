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
			textBox4.Clear();

			foreach(var s in _cypher.LetterDict)
			{
				textBox4.Text += $"{ s.Key } - { s.Value }{ Environment.NewLine }";
			}
		}

		void ReplaceSymbols()
		{
			using(var window = new ChangeForm())
			{
				switch(window.ShowDialog(this))
				{
					case DialogResult.OK:
						{
							// TODO: Взять данные из формы и поменять буквы
							var symbolFromKey = _cypher.LetterDict.Where(p => p.Value == window.SymbolFrom).Select(p => p.Key).ToList()[0];
							var symbolToKey = _cypher.LetterDict.Where(p => p.Value == window.SymbolTo).Select(p => p.Key).ToList()[0];

							var buf = _cypher.LetterDict[symbolFromKey];
							_cypher.LetterDict[symbolFromKey] = _cypher.LetterDict[symbolToKey];
							_cypher.LetterDict[symbolToKey] = buf;

							break;
						}
					case DialogResult.Cancel:
						{
							break;
						}
				}
			}

			PrintLetters();

			_cypher.PrintText();
			textBox3.Clear();
			textBox3.Text = _cypher.ResultText;
		}

		private void OnButtonReplaceSymbolClick(object sender, EventArgs e)
		{
			ReplaceSymbols();
		}
	}
}
