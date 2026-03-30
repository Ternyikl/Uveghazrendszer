using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Meres
	{
		private Random rnd = new Random();
		private double nedevesseg;
		private double homerseklet;
		private double suruseg;

		public Meres()
		{
			this.nedevesseg = rnd.NextDouble() * 100;
			this.homerseklet = rnd.NextDouble() * 60;
			this.suruseg = rnd.NextDouble() * 100;
		}

		public double Nedevesseg { get => nedevesseg; set => nedevesseg = value; }
		public double Homerseklet { get => homerseklet; set => homerseklet = value; }
		public double Suruseg { get => suruseg; set => suruseg = value; }
	}
}
