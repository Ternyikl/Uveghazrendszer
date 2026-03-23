using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Novenyfaj
	{
		private string azonosito;
		private string nev;
		private double idealTalajNedvesseg;
		private double idealTalajHomerseklet;
		private int minSuruseg;
		private int idealSuruseg;
		private int maxSuruseg;

		public Novenyfaj(string nev, double idealTalajNedvesseg, double idealTalajHomerseklet, int minSuruseg, int idealSuruseg, int maxSuruseg)
		{
			this.nev = nev;
			this.azonosito = this.nev.Substring(0, 3);
			this.idealTalajNedvesseg = idealTalajNedvesseg;
			this.idealTalajHomerseklet = idealTalajHomerseklet;
			this.minSuruseg = minSuruseg;
			this.idealSuruseg = idealSuruseg;
			this.maxSuruseg = maxSuruseg;
		}

		public string Azonosito { get => azonosito; }
		public string Nev { get => nev; set => nev = value; }
		public double IdealTalajNedvesseg { get => idealTalajNedvesseg; set => idealTalajNedvesseg = value; }
		public double IdealTalajHomerseklet { get => idealTalajHomerseklet; set => idealTalajHomerseklet = value; }
		public int MinSuruseg { get => minSuruseg; set => minSuruseg = value; }
		public int IdealSuruseg { get => idealSuruseg; set => idealSuruseg = value; }
		public int MaxSuruseg { get => maxSuruseg; set => maxSuruseg = value; }

		public override string ToString()
		{
			return $"{this.nev}({this.azonosito}): \n\tideális nedvesség: {this.idealTalajNedvesseg}%\n\tideális hőmérséklet: {this.idealTalajHomerseklet}\n\tideális sűrűség: {this.idealSuruseg} --> Min:{this.minSuruseg}/Max{this.maxSuruseg}";
		}
	}
}
