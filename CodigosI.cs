using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Insira o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        string mensagem;

        mensagem = (numero2 != 0 && numero1 % numero2 == 0) ? "O número " +numero1+ " é divisível por " +numero2 : "O número não é divisível.";

        Console.WriteLine(mensagem);
        
		    Console.ReadKey(true);
    }
  
}
