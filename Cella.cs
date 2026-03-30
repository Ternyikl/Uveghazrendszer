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
		private List<Riasztasok> riasztas;

		public Cella(int[] pozicio, Novenyfaj noveny, int egyedszam, Szenzor szenzorok)
		{
			this.pozicio = pozicio;
			this.noveny = noveny;
			this.egyedszam = egyedszam;
			this.szenzorok = szenzorok;
			this.riasztas = new List<Riasztasok>();
		}

		public int[] Pozicio { get => pozicio; set => pozicio = value; }
		public int Egyedszam { get => egyedszam; set => egyedszam = value; }
		internal Novenyfaj Noveny { get => noveny; set => noveny = value; }
		internal Szenzor Szenzorok { get => szenzorok; set => szenzorok = value; }
		internal List<Riasztasok> Riasztas { get => riasztas; set => riasztas = value; }

		public bool Ures()
		{
			return  (egyedszam == 0) ? true : false;
		}

		public void
			Telepit(Novenyfaj noveny, int mennyiseg)
		{
			if(Ures())
			{
				this.noveny = noveny;
				this.egyedszam = mennyiseg;
				Console.WriteLine($"A {this.noveny}-ből {this.egyedszam} be lett öltetve a {this.pozicio[0]}:{this.pozicio[1]} pozicióra");
			}
			else
			{
				if(noveny == this.noveny)
				{
					this.egyedszam += mennyiseg;
					Console.WriteLine($"A {this.noveny}-hez {mennyiseg} hozzá let öltetve a {this.pozicio[0]}:{this.pozicio[1]} pozicióra");
				}
				else
				{
					Console.WriteLine($"A {this.pozicio[0]}:{this.pozicio[1]} pozición egy másik növény már szerepel");
				}
			}
		}

		public void Noveles(int mennyiseg)
		{
			this.egyedszam += mennyiseg;
			Console.WriteLine($"{mennyiseg} hozzá lett adva a {this.noveny} ültetvényhez.");
		}

		public void Csokkentes(int mennyiseg)
		{
			this.egyedszam -= mennyiseg;
			Console.WriteLine($"{mennyiseg} ki lett kapálva a {this.noveny} ültetvényből.");
		}

		public void Urit()
		{
			this.egyedszam = 0;
			this.noveny = null;
			this.szenzorok = null;
			this.riasztas = null;
			Console.WriteLine($"A {this.pozicio[0]}:{this.pozicio[1]} pozición lévő cella ki lett kapálva.");
		}

		public void CellaErtekelo()
		{
			riasztas.Clear();
			if(!Ures())
			{
				double seged = 0;
				#region nedvesseg
				double nedvesseg_k = noveny.IdealTalajNedvesseg - szenzorok.Meresek.Nedevesseg;

				if (nedvesseg_k < 0) seged = nedvesseg_k * (-1);

				if (seged > 50)
				{
					if (nedvesseg_k < 0)
					{
						riasztas.Append(new Riasztasok(Problema.Nedvesség_alacsony, "Extrém súlyosságú próbléma: alacsony nedvesség", Sulyossag.Extrém));
					}
					else
					{
						riasztas.Append(new Riasztasok(Problema.Nedvesség_magas, "Extrém súlyoságú próbléma: magas nedvesség", Sulyossag.Extrém));
					}
				}
				else if (seged > 30)
				{
					if (nedvesseg_k < 0)
					{
						riasztas.Append(new Riasztasok(Problema.Nedvesség_alacsony, "Magas súlyosságú próbléma: alacsony nedvesség", Sulyossag.Magas));
					}
					else
					{
						riasztas.Append(new Riasztasok(Problema.Nedvesség_magas, "Magas súlyosságú próbléma: magas nedvesség", Sulyossag.Magas));
					}
				}
				else if (seged > 20)
				{
					if (nedvesseg_k < 0)
					{
						riasztas.Append(new Riasztasok(Problema.Nedvesség_alacsony, "Közepes súlyosságú próbléma: alacsony nedvesség", Sulyossag.Közepes));
					}
					else
					{
						riasztas.Append(new Riasztasok(Problema.Nedvesség_magas, "Közepes súlyoságú próbléma: magas nedvesség", Sulyossag.Közepes));
					}
				}
				else if (seged > 10)
				{
					if (nedvesseg_k < 0)
					{
						riasztas.Append(new Riasztasok(Problema.Nedvesség_alacsony, "Alacsony súlyosságú próbléma: alacsony nedvesség", Sulyossag.Alacsony));
					}
					else
					{
						riasztas.Append(new Riasztasok(Problema.Nedvesség_magas, "Alacsony súlyoságú próbléma: magas nedvesség", Sulyossag.Alacsony));
					}
				}
				#endregion

				#region homerseklet
				double homerseklet_k = noveny.IdealTalajNedvesseg - szenzorok.Meresek.Nedevesseg;

				if (homerseklet_k < 0) seged = nedvesseg_k * (-1);

				if (seged > 30)
				{
					if (homerseklet_k < 0)
					{
						riasztas.Append(new Riasztasok(Problema.Hőmérséklet_alacsony, "Extrém súlyosságú próbléma: alacsony hőmérséklet", Sulyossag.Extrém));
					}
					else
					{
						riasztas.Append(new Riasztasok(Problema.Hőmérséklet_magas, "Extrém súlyoságú próbléma: magas hőmérséklet", Sulyossag.Extrém));
					}
				}
				else if (seged > 20)
				{
					if (homerseklet_k < 0)
					{
						riasztas.Append(new Riasztasok(Problema.Hőmérséklet_alacsony, "Magas súlyosságú próbléma: alacsony hőmérséklet", Sulyossag.Magas));
					}
					else
					{
						riasztas.Append(new Riasztasok(Problema.Hőmérséklet_magas, "Magas súlyosságú próbléma: magas hőmérséklet", Sulyossag.Magas));
					}
				}
				else if (seged > 10)
				{
					if (homerseklet_k < 0)
					{
						riasztas.Append(new Riasztasok(Problema.Hőmérséklet_alacsony, "Közepes súlyosságú próbléma: alacsony hőmérséklet", Sulyossag.Közepes));
					}
					else
					{
						riasztas.Append(new Riasztasok(Problema.Hőmérséklet_magas, "Közepes súlyoságú próbléma: magas hőmérséklet", Sulyossag.Közepes));
					}
				}
				else if (seged > 5)
				{
					if (homerseklet_k < 0)
					{
						riasztas.Append(new Riasztasok(Problema.Hőmérséklet_alacsony, "Alacsony súlyosságú próbléma: alacsony hőmérséklet", Sulyossag.Alacsony));
					}
					else
					{
						riasztas.Append(new Riasztasok(Problema.Hőmérséklet_magas, "Alacsony súlyoságú próbléma: magas hőmérséklet", Sulyossag.Alacsony));
					}
				}
				#endregion

				#region suruseg
				if(noveny.MaxSuruseg < szenzorok.Meresek.Suruseg)
				{
					riasztas.Append(new Riasztasok(Problema.Sűrűség_tömött, "Extrém súlyosságú próbléma: túl tömötten vam ültetve", Sulyossag.Extrém));
				}

				if (noveny.MinSuruseg > szenzorok.Meresek.Suruseg)
				{
					riasztas.Append(new Riasztasok(Problema.Sűrűség_ritka, "Extrém súlyosságú próbléma: túl ritkán vam ültetve", Sulyossag.Extrém));
				}

				if(noveny.MaxSuruseg >= szenzorok.Meresek.Suruseg && noveny.MinSuruseg > szenzorok.Meresek.Suruseg && noveny.IdealSuruseg < szenzorok.Meresek.Suruseg)
				{
					riasztas.Append(new Riasztasok(Problema.Sűrűség_tömött, "Közepes súlyosságú próbléma: túl tömötten vam ültetve", Sulyossag.Közepes));
				}

				if (noveny.MaxSuruseg >= szenzorok.Meresek.Suruseg && noveny.MinSuruseg > szenzorok.Meresek.Suruseg && noveny.IdealSuruseg > szenzorok.Meresek.Suruseg)
				{
					riasztas.Append(new Riasztasok(Problema.Sűrűség_ritka, "Közepes súlyosságú próbléma: túl ritkán vam ültetve", Sulyossag.Közepes));
				}
				#endregion
			}
		}
	}
}
