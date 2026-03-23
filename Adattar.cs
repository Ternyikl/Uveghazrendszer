using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Adattar
	{
		private List<Kezelo> kezelo;
		private List<UveghazRacs> uveghaz;
		private List<Riasztasok> riasztasok;
		private List<Beavatkozas> beavatkozas;

		public Adattar(List<Kezelo> kezelo, List<UveghazRacs> uveghaz, List<Riasztasok> riasztasok, List<Beavatkozas> beavatkozas)
		{
			this.kezelo = kezelo;
			this.uveghaz = uveghaz;
			this.riasztasok = riasztasok;
			this.beavatkozas = beavatkozas;
		}

		internal List<Kezelo> Kezelo { get => kezelo; set => kezelo = value; }
		internal List<UveghazRacs> Uveghaz { get => uveghaz; set => uveghaz = value; }
		internal List<Riasztasok> Riasztasok { get => riasztasok; set => riasztasok = value; }
		internal List<Beavatkozas> Beavatkozas { get => beavatkozas; set => beavatkozas = value; }
	}
}
