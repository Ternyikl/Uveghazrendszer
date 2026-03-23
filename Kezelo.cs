using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Kezelo
	{
		private string nev;
		private string azonosito;
		private Szerep szerepkor;

		public Kezelo(string nev, Szerep szerepkor)
		{
			this.nev = nev;
			this.azonosito = this.nev.Substring(0,3);
			this.szerepkor = szerepkor;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Azonosito { get => azonosito; }
		internal Szerep Szerepkor { get => szerepkor; set => szerepkor = value; }

		public override string ToString()
		{
			return $"{this.nev}({this.azonosito}): {this.szerepkor}";
		}
	}
}
