using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_aura2
{
    internal class program
    {
        static void Main(string[] args)
        {

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados existentes do primeiro funcionario");
            Console.WriteLine("nome:");
            f1.nome = Console.ReadLine();
            Console.WriteLine("salario:");
            f1.salario= double.Parse (Console.ReadLine());

            Console.WriteLine("Dados existentes do segundo funcionario");
            Console.WriteLine("nome:");
            f2.nome= Console.ReadLine();
            Console.WriteLine("salario:");
            f2.salario = double.Parse (Console.ReadLine());

            double media = ((f1.salario + f2.salario) / 2);

            Console.WriteLine("a media dos seus salarios é:" + media);




		}
    }
}
