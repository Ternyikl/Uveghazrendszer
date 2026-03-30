using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Szenzor
	{
		private Random rnd = new Random();

		private string azonosito;
		private Meres meresek;

		public Szenzor(string azonosito)
		{
			this.azonosito = azonosito;
			this.meresek = new Meres();
		}

		public string Azonosito { get => azonosito; set => azonosito = value; }
		internal Meres Meresek { get => meresek; set => meresek = value; }
	}
}
