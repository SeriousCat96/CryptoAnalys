using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	public class HashAlgorithm
	{
		public int Hash(string input)
		{
			// 1) Прибавить длину строки

			var out1 = input + input.Length;

			// 2) Циклический повтор строки до 128 символов

			var sb = new StringBuilder();
			int idx = 128;

			while(idx > 0)
			{
				if(idx >= out1.Length)
				{ 
					sb.Append(out1);
					idx -= out1.Length;
				}
				else
				{
					var rem = out1.Substring(0, idx);
					sb.Append(rem);
					idx = 0;
				}
			}

			var out2 = sb.ToString();

			// 3) Подсчет хеш-суммы

			byte[] h = new byte[24];
			byte[] s = Encoding.Default.GetBytes(out2);
			byte[] t = new byte[129];

			Array.ConstrainedCopy(s, 0, t, 1, s.Length);

			byte[] new_t = new byte[129];
			byte g = 1;
			byte new_g = 0;

			for(int i = 0; i < h.Length; i++)
			{
				t[0] = g;
				new_g = Func_G(h[i], g);
				new_t[0] = new_g;
				for(int j = 1; j < t.Length; j++)
				{
					new_t[j] = Func_T_All(new_t[j - 1], t[j - 1], Func_T_Down(t[j - 1], t[j]));
				}

				h[i] = new_t[128];
				g = new_g;
				t = new_t;
			}

			var sum = new List<byte>(h).Select(e => (int)e).Sum();
			return sum;
		}

		private byte Func_G(byte left, byte up)
		{
			return (byte)(((up + 23) << 3) + left);
		}


		private byte Func_T_Down(byte left, byte up)
		{
			var b = up << 3;
			var a = left + b;
			return (byte)(a);
		}

		private byte Func_T_All(byte left, byte upleft, byte up)
		{

			var a = 165 + upleft;

			var tmp = Func_T_Down(left, up);

			var b = a + tmp;

			return (byte)(b);
		}

	}
}
