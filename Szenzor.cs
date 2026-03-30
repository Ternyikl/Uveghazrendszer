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
		}

		public string Azonosito { get => azonosito; set => azonosito = value; }
		public Meres Meresek 
		{ 
			get => meresek;
			set
			{
				meresek.Nedevesseg = rnd.NextDouble() * 100;
				meresek.Homerseklet = rnd.NextDouble() * 60;
				meresek.Suruseg = rnd.NextDouble() * 100;

			}
		}
	}
}
