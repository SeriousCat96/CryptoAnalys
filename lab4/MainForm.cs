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

namespace lab4
{
	public partial class MainForm : Form
	{
		static int size = 13;

		//содержит значения времени
		long[] ticks = new long[size];

		//содержит интервалы между ними
		long[] tickDiff = new long[size - 1];

		ushort[] tickDiffUshort = new ushort[size - 1];

		BitArray[] tickDiffBits = new BitArray[(size - 1)];

		double[] dt = new double[size - 1];


		int keyPressedTimes = 0;
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Нажмите клавиши 13 раз");
		}

		private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			//if(keyPressedTimes < ticks.Length)
			//{
			//	ticks[keyPressedTimes++] = DateTime.Now.Ticks;

			//}

			//else
			//{
			//	makeDiff();
			//	rtbReturnedKey.Text += KeyMaker.ReturnKey(tickDiff).ToString() + Environment.NewLine + Environment.NewLine;
			//}
		}

		private void makeDiff()
		{
			for(int i = 0; i< size-1; i++)
			{
				tickDiff[i] = (ticks[i + 1] - ticks[i]);

				//приводим к значениям 0..65535
				tickDiffUshort[i] = (ushort)tickDiff[i];

				//returns 2 [] bytes
				var v = BitConverter.GetBytes(tickDiffUshort[i]);

				//создаем элемент BitArray длина 2*byte = 16 bit (true/false)
				tickDiffBits[i] = new BitArray(v);


				//вычисляем кол-во секунд между нажатиями
				dt[i] = new TimeSpan(tickDiff[i]).TotalSeconds;
			}
		}

		private void OnbtnMakeNewKey_Click(object sender, EventArgs e)
		{
			keyPressedTimes = 0;
			MessageBox.Show("Нажмите клавиши 13 раз");
		}

		private int getIntFromBitArray(BitArray bitArray)
		{
			int[] array = new int[1];
			bitArray.CopyTo(array, 0);
			return array[0];
		}

		private void rtbReturnedKey_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(keyPressedTimes < ticks.Length)
			{
				ticks[keyPressedTimes++] = DateTime.Now.Ticks;
			}

			else
			{
				makeDiff();
				var representation = KeyMaker.ReturnKey(tickDiffBits);

				StringBuilder sb = new StringBuilder();
				foreach(var r in representation)
				{
					sb.Append(getIntFromBitArray(r) + " ");
				}

				StringBuilder sb_diffs = new StringBuilder();
				foreach(var r in tickDiffUshort)
				{
					sb_diffs.Append(r + " ");
				}

				StringBuilder sb_sec = new StringBuilder();
				foreach(var r in dt)
				{
					sb_sec.Append(r + " sec, ");
				}

				rtbReturnedKey.Text += $"Diff between keys:{Environment.NewLine}{sb_sec.ToString().Substring(0, sb_sec.Length-2)}{Environment.NewLine}"+
										$"{Environment.NewLine}{tickDiffUshort.Length} Coundowns in bits: {Environment.NewLine}{sb_diffs.ToString()}"+
										$"{Environment.NewLine}Normalized values: {Environment.NewLine}{sb.ToString()}{Environment.NewLine}" +
										$"{Environment.NewLine}{Environment.NewLine}";
			}
		}
	}
}
