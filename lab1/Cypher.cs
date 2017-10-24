using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	public class Cypher
	{
		public Cypher()
		{
			Read("input.txt");
			GetProbabilities();
		}

		public Dictionary<string, string> LetterDict;
		public string[] Symbols { get; set; }
		public Dictionary<string, double> Probabilities { get; set; }
		public string Text { get; set; }
		public string ResultText { get; set; }
		//public string[] Text { get; set; }
		//public string[] ResultText { get; set; }

		public void Read(string filename)
		{
			Text = File.ReadAllText(filename);
			//Text = text.Split(new char[] { ' ', '\r', '\n' });
			var symbols = Text.Split(new char[] { ' ', '\r', '\n', '.', ',' });

			Symbols = symbols;
		}

		public void GetProbabilities()
		{
			var symbolsCount = 0;

			foreach(var symbol in Symbols)
			{
				if(symbol != string.Empty)
				{
					symbolsCount++;
				}
			}

			var probabilities = new Dictionary<string, double>();

			foreach(var symbol in Symbols)
			{
				if(symbol == string.Empty || probabilities.ContainsKey(symbol))
				{
					continue;
				}

				int count = 0;
				foreach(var s in Symbols)
				{

					if(s != symbol)
					{
						continue;
					}

					count++;
				}

				probabilities.Add(symbol, Math.Round((double)count / symbolsCount, 6));
			}

			Probabilities = probabilities;
		}

		public string ShowProbabilities()
		{
			var orderedSymbols = Probabilities
				.OrderByDescending(e => e.Value);
			//.Select(s => s.Key);

			var sb = new StringBuilder();

			double sum = 0;
			foreach(var pair in orderedSymbols)
			{
				sb.Append($"Symbol: {pair.Key} - Frequency: {pair.Value}{Environment.NewLine}");
				sum += pair.Value;
			}

			sb.Append($"Sum: {sum}");
			return sb.ToString();
		}

		public void DefaultDistribution()
		{
			var orderedSymbols = Probabilities
				.OrderByDescending(e => e.Value).ToList();

			LetterDict = new Dictionary<string, string>()
			{
				{ orderedSymbols[0].Key, "O" },
				{ orderedSymbols[1].Key, "Е" },
				{ orderedSymbols[2].Key, "А" },
				{ orderedSymbols[3].Key, "И" },
				{ orderedSymbols[4].Key, "Т" },
				{ orderedSymbols[5].Key, "Н" },
				{ orderedSymbols[6].Key, "С" },
				{ orderedSymbols[7].Key, "Р" },
				{ orderedSymbols[8].Key, "В" },
				{ orderedSymbols[9].Key, "Л" },
				{ orderedSymbols[10].Key, "К" },
				{ orderedSymbols[11].Key, "М" },
				{ orderedSymbols[12].Key, "Д" },
				{ orderedSymbols[13].Key, "П" },
				{ orderedSymbols[14].Key, "У" },
				{ orderedSymbols[15].Key, "Я" },
				{ orderedSymbols[16].Key, "Ы" },
				{ orderedSymbols[17].Key, "З" },
				{ orderedSymbols[18].Key, "Ь" },
				{ orderedSymbols[19].Key, "Ъ" },
				{ orderedSymbols[20].Key, "Б" },
				{ orderedSymbols[21].Key, "Г" },
				{ orderedSymbols[22].Key, "Ч" },
				{ orderedSymbols[23].Key, "Й" },
				{ orderedSymbols[24].Key, "Х" },
				{ orderedSymbols[25].Key, "Ж" },
				{ orderedSymbols[26].Key, "Ю" },
				{ orderedSymbols[27].Key, "Ш" },
				{ orderedSymbols[28].Key, "Ц" },
				{ orderedSymbols[29].Key, "Щ" },
				//{ "", "Э" },
				//{ "", "Ф" },
			};

			ResultText = string.Copy(Text);

			foreach(var s in LetterDict)
			{
				if (s.Key != "")
					ResultText = ResultText.Replace(s.Key, s.Value);
			}

		}
	}
}
