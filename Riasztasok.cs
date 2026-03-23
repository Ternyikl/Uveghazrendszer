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
		private Cella cella;

		public Riasztasok(string azonosito, Problema tipus, string leiras, Sulyossag sulyossag, Cella cella)
		{
			this.azonosito = azonosito;
			this.tipus = tipus;
			this.leiras = leiras;
			this.sulyossag = sulyossag;
			this.cella = cella;
		}

		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		internal Problema Tipus { get => tipus; set => tipus = value; }
		internal Sulyossag Sulyossag { get => sulyossag; set => sulyossag = value; }
		internal Cella Cella { get => cella; set => cella = value; }

		public override string ToString()
		{
			return $"{this.azonosito}: {this.cella.Pozicio} - {this.tipus}({this.sulyossag})\n\tLeírás: {this.leiras}";
		}
	}
}
