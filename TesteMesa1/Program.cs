using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== TESTE DE MESA =====");
        Console.WriteLine("1 - Exercício 1");
        Console.WriteLine("2 - Exercício 2");
        Console.WriteLine("3 - Exercício 3");
        Console.Write("Escolha uma opção: ");

        string? opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Exercicio1.Run();
                break;
            case "2":
                Exercicio2.Run();
                break;
            case "3":
                Exercicio3.Run();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}