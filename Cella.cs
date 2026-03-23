using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Cella
	{
		private int[] pozicio;
		private Novenyfaj noveny;
		private int egyedszam;
		private Szenzor szenzorok;
		private Riasztasok[] riasztas;

		public Cella(int[] pozicio, Novenyfaj noveny, int egyedszam, Szenzor szenzorok, Riasztasok[] riasztas)
		{
			this.pozicio = pozicio;
			this.noveny = noveny;
			this.egyedszam = egyedszam;
			this.szenzorok = szenzorok;
			this.riasztas = riasztas;
		}

		public int[] Pozicio { get => pozicio; set => pozicio = value; }
		public int Egyedszam { get => egyedszam; set => egyedszam = value; }
		internal Novenyfaj Noveny { get => noveny; set => noveny = value; }
		internal Szenzor Szenzorok { get => szenzorok; set => szenzorok = value; }
		internal Riasztasok[] Riasztas { get => riasztas; set => riasztas = value; }

		public bool Ures()
		{
			return  (egyedszam == 0) ? true : false;
		}

		public void Telepit(Novenyfaj noveny, int mennyiseg)
		{
			if(Ures())
			{
				this.noveny = noveny;
				this.egyedszam = mennyiseg;
				Console.WriteLine($"");
			}
		}
	}
}
