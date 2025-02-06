using System;

class Program
{
    static void Main()
    {
        Console.Write("insira um número: ");
        string str = Console.ReadLine();

        int num;
        string mensagem = int.TryParse(str, out num) ?  "Você digitou o número: " +num :" A entrada não é um número válido.";

        Console.WriteLine(mensagem);

	      Console.ReadKey(true);

    }
}
