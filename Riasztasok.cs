using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Riasztasok
	{
		private string azonosito;
		private Problema tipus;
		private string leiras;
		private Sulyossag sulyossag;
		private int counter;

		public Riasztasok(Problema tipus, string leiras, Sulyossag sulyossag)
		{
			this.counter = 1;
			this.azonosito = counter++.ToString();
			this.tipus = tipus;
			this.leiras = leiras;
			this.sulyossag = sulyossag;
		}

		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		internal Problema Tipus { get => tipus; set => tipus = value; }
		internal Sulyossag Sulyossag { get => sulyossag; set => sulyossag = value; }

		public override string ToString()
		{
			return $"{this.azonosito}: {this.tipus}({this.sulyossag})\n\tLeírás: {this.leiras}";
		}
	}
}
