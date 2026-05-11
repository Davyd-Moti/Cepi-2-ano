using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_aura_2
{
	internal class Calculadora
	{


		public double pi = 3.14;
		public double circunferencia(double r)
		{
			return 2.0 * pi * r;
		}
		public double Volume(double r)
		{
			return 4.0 / 3.0 * pi * r * r * r;
		}
	}
}
