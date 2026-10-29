using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1-Consultar saldo");
        Console.WriteLine("2-Fazer deposito");
        Console.WriteLine("3-sair");
        
        int opcoes = int.Parse (Console.ReadLine());
        
        switch (opcoes)
        {
            case 1:
            Console.WriteLine("Você escolheu consultar seu saldo");
            break;
            
            case 2:
            Console.WriteLine("Você escolheu fazer um deposito");
            break;
            
            case 3:
            Console.WriteLine("Você escolheu sair");
            break;
            
            default:
            Console.WriteLine("opção invalida");
            break;
        }

   
    }
}
