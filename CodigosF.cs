using System;
using System.Collections.Generic;

namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um número: ");
			int numero = Convert.ToInt32(Console.ReadLine());
			
			int numeroabs = (numero < 0) ? -numero : numero;
			                   
			Console.WriteLine("O valor absoluto desse número é " +numeroabs);
		
			Console.ReadKey(true);
		}
    
	}
  
}
