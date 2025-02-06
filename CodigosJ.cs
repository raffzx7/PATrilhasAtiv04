using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira im número: ");
        int numero1 = int.Parse(Console.ReadLine());

        string mensagem;

        mensagem = (numero1 != 0) ? "O número " +numero1+ " não é nulo ": "O número é nulo.";

        Console.WriteLine(mensagem);
      
		    Console.ReadKey(true);
    }
  
}
