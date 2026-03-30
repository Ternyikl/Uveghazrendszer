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
		private List<Beavatkozas> beavatkozas;

		public Adattar(List<Kezelo> kezelo, List<UveghazRacs> uveghaz, List<Beavatkozas> beavatkozas)
		{
			this.kezelo = kezelo;
			this.uveghaz = uveghaz;
			this.beavatkozas = beavatkozas;
		}

		internal List<Kezelo> Kezelo { get => kezelo; set => kezelo = value; }
		internal List<UveghazRacs> Uveghaz { get => uveghaz; set => uveghaz = value; }
		internal List<Beavatkozas> Beavatkozas { get => beavatkozas; set => beavatkozas = value; }

		public void Kezelo_kiir()
		{
			foreach(var item in kezelo)
			{
				Console.WriteLine(item);
			}
		}

		public void Uveghaz_kiir()
		{
			foreach (var item in uveghaz)
			{
				item.TerkepKiir();
			}
		}

		public void Beavatkozas_kiir()
		{
			foreach (var item in beavatkozas)
			{
				Console.WriteLine(item);
			}
		}
	}
}
