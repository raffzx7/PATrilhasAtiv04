using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira o primeiro número : ");
			int numero =Convert.ToInt32(Console.ReadLine());
		 	
			Console.Write("Insira o segundo número : ");
			int numero2 =Convert.ToInt32(Console.ReadLine());
			
			int maior = (numero > numero2) ? numero : numero2;
			                   
			Console.WriteLine("O maior número é " +maior);
      
			Console.ReadKey(true);
		}
    
	}
  
}
