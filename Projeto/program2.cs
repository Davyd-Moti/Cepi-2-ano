using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace projeto_aura_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Pessoa t1 = new Pessoa();
            Pessoa t2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            t1.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            t1.idade = int.Parse(Console.ReadLine());

			Console.WriteLine("Dados da segunda pessoa: ");
			Console.WriteLine("Nome: ");
			t2.nome = Console.ReadLine();
			Console.WriteLine("Idade: ");
			t2.idade = int.Parse(Console.ReadLine());

            if 
                (t1.idade > t2.idade)
            {
                Console.WriteLine("a pessoa mais velha é " + t1.nome);
            }
            else 
            {
                Console.WriteLine("a pessoa mais velha é " + t2.nome);
            }*/
           
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Dados do produto: ");
            Console.WriteLine("");
            Console.WriteLine("Digite o número de produtos a ser adicionado no Estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos (qte);
			Console.WriteLine("");
			Console.WriteLine("Dados do atualizados: " +p);
			Console.WriteLine("");

            Console.WriteLine("Digite número de produtos a serem removidos do Estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos (qte);
			Console.WriteLine("");
			Console.WriteLine("Dados atualizados: "+p);
