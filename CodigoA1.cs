using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("insira um número: ");
			int numero =Convert.ToInt32(Console.ReadLine());
		 	
			string resposta = (numero % 2 == 0) ? "Par" : "Ímpar";
			                   
			Console.WriteLine("O número " +numero+ " é " +resposta);
			Console.ReadKey(true);
		}
    
	}
  
}
