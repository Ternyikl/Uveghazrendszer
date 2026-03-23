using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Beavatkozas
	{
		private Problema tipus;
		private DateTime datum;
		private Cella cella;
		private string megjegyzes;

		public Beavatkozas(Problema tipus, DateTime datum, Cella cella, string megjegyzes)
		{
			this.tipus = tipus;
			this.datum = datum;
			this.cella = cella;
			this.megjegyzes = megjegyzes;
		}

		public DateTime Datum { get => datum; set => datum = value; }
		public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }
		internal Problema Tipus { get => tipus; set => tipus = value; }
		internal Cella Cella { get => cella; set => cella = value; }

		public override string ToString()
		{
			return $" {this.cella.Pozicio} - {this.tipus}({this.datum})\n\tMegjegyzés: {this.megjegyzes}";
		}
	}
}
