using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Meres
	{
		private double nedevesseg;
		private double homerseklet;
		private double suruseg;

		public Meres(double nedevesseg, double homerseklet, double suruseg)
		{
			this.nedevesseg = nedevesseg;
			this.homerseklet = homerseklet;
			this.suruseg = suruseg;
		}

		public double Nedevesseg { get => nedevesseg; set => nedevesseg = value; }
		public double Homerseklet { get => homerseklet; set => homerseklet = value; }
		public double Suruseg { get => suruseg; set => suruseg = value; }
	}
}
