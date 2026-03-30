using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class NovenyKezelo
	{
		private List<Novenyfaj> novenyfajLista;
		private UveghazRacs uveghaz;

		public NovenyKezelo(List<Novenyfaj> novenyfajLista, UveghazRacs uveghaz)
		{
			this.novenyfajLista = novenyfajLista;
			this.uveghaz = uveghaz;
		}

		internal List<Novenyfaj> NovenyfajLista { get => novenyfajLista; set => novenyfajLista = value; }
		internal UveghazRacs Uveghaz { get => uveghaz; set => uveghaz = value; }

		public void NovenyfajHozzaad()
		{
			Console.Write("Kérem adja meg a növényfaj adatit vesszővel elválasztva: ");
			string[] seged = Console.ReadLine().Split(',');

			string nev = seged[0];
			double tn = double.Parse(seged[1]);
			double th = double.Parse(seged[2]);
			int mis = int.Parse(seged[3]);
			int ids = int.Parse(seged[4]);
			int mas = int.Parse(seged[5]);


			Novenyfaj novenyfaj = new Novenyfaj(nev, tn, th, mis, ids, mas);
			novenyfajLista.Append(novenyfaj);
		}

		public void Telepites(Novenyfaj noveny, int x, int y, int mennyiseg)
		{
			if(!novenyfajLista.Contains(noveny)) return;

			if (uveghaz.Racs[x, y].Ures())
			{
				uveghaz.Racs[x, y].Telepit(noveny, mennyiseg);
			}
			else
			{
				Cella urescella = uveghaz.Urescella();

				uveghaz.Racs[urescella.Pozicio[0], urescella.Pozicio[1]].Telepit(noveny, mennyiseg);
			}
		}
	}
}
