using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_aura_2;

namespace Projeto_aura3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


			Calculadora calc = new Calculadora();

			Console.WriteLine("Entre com o valor do Raio: ");
			double raio = double.Parse(Console.ReadLine());

			double circ = calc.circunferencia(raio);
			double volume = calc.Volume(raio);

			Console.WriteLine("circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Valor de PI: " + calc.pi.ToString("F2", CultureInfo.InvariantCulture));

		}
	}
}
