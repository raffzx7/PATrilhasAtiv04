using System;
using System.Collections.Generic;

namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("insira um número: ");
			int numero = Convert.ToInt32(Console.ReadLine());
			
			string comparacao = (numero > 0) ? "O número é maior que zero.": (numero < 0 ? "O número é menor que zero." : "O número é igual a zero.");
			                   
			Console.WriteLine(comparacao);

			Console.ReadKey(true);
		}
    
	}
  
}
