using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace projeto_aura_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();

            Console.WriteLine("qual a largura e a altura do seu retangulo ");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Area = " +R.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" Perimetro = "+R.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = "+R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));



		}
    }
}
