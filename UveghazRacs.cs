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

		public Cella Urescella()
		{
			Cella urescella = null;

			for (int i = 0; i < racs.GetLength(0); i++)
			{
				for (int j = 0; j < racs.GetLength(1); j++)
				{
					if (racs[i,j].Ures() == true)
					{
						urescella = racs[i,j];
						return urescella;
					}
				}
			}

			Console.WriteLine("Az üveg házban nincs üres cella");
			return urescella;
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

		public void Beavatkozo(int x, int y, Problema problema, double ertek)
		{
			if (racs[x,y].Ures())
			{
				Console.WriteLine("A megadott cella üres!");
				return;
			}
			else
			{
				switch(problema)
				{
					case Problema.Nedvesség_alacsony:
						racs[x, y].Szenzorok.Meresek.Nedevesseg += ertek;
						break;

					case Problema.Nedvesség_magas:
						racs[x, y].Szenzorok.Meresek.Nedevesseg += ertek;
						break;

					case Problema.Hőmérséklet_alacsony:
						racs[x, y].Szenzorok.Meresek.Homerseklet += ertek;
						break;

					case Problema.Hőmérséklet_magas:
						racs[x, y].Szenzorok.Meresek.Homerseklet += ertek;
						break;

					case Problema.Sűrűség_ritka:
						racs[x, y].Noveles((int)ertek);
						break;

					case Problema.Sűrűség_tömött:
						racs[x, y].Csokkentes((int)ertek);
						break;

					default:
						Console.WriteLine("Hibás érték");
						break;
				}
			}
		}
	}
}
