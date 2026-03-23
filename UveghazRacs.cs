using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class UveghazRacs
	{
		private int meret;
		private Cella[,] racs;

		public UveghazRacs(int meret, Cella[,] racs)
		{
			this.meret = meret;
			this.racs = racs;
		}

		public int Meret { get => meret; set => meret = value; }
		internal Cella[,] Racs { get => racs; set => racs = value; }

		public Cella CellaLekerdez(int x, int y)
		{
			return racs[x, y];
		}

		public List<Cella> Szomszedok(int x, int y)
		{
			List<Cella> cellak = new List<Cella>();

			for (int i = -1; i <= 1; i++)
			{
				for (int j = -1; j <= 1; j++)
				{
					if (i == 0 && j == 0) continue;

					int sz_x = x + i;
					int sz_y = y + j;

					if (sz_x >= 0 && sz_x < racs.GetLength(0) &&
						sz_y >= 0 && sz_y < racs.GetLength(1))
					{
						cellak.Add(racs[sz_x, sz_y]);
					}
				}
			}

			return cellak;
		}

		public void TerkepKiir()
		{
			for (int i = 0; i < racs.GetLength(0); i++)
			{
				for (int j = 0; j < racs.GetLength(1); j++)
				{
					Console.Write($"{racs[i,j].Noveny, 32}");
				}
				Console.Write("\n");
			}
		}
	}
}
