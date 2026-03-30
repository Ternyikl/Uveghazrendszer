using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kezelo k1 = new Kezelo("Pisti", Szerep.Technikus);

			Novenyfaj birb = new Novenyfaj("Birb", 51.3, 25.6, 13, 5, 52);

			Szenzor sz1 = new Szenzor("sz_1");

			int[] kordinata = new int[2] {0, 0};

			Cella c1 = new Cella(kordinata, birb, 13, sz1);

			List<Cella> lista = new List<Cella>() { c1};

			UveghazRacs u1 = new UveghazRacs(1, lista);
		}
	}
}
