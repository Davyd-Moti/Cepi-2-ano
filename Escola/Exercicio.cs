using System;
using System.Collections.Generic;
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
            Funcionario f = new Funcionario();

            Console.WriteLine("qual é o seu nome? ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("qual é o seu sálario bruto? ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto a pagar: ");
            f.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("funcionario: " +f);
            Console.WriteLine("deseja aumentar o salario em qual porcentagem? ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + f);

		}
    }
}
