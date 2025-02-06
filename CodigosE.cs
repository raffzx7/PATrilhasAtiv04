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
			
			String respsota = (numero != 0) ? "O número é diferente de zero.": "O número é igual a zero.";
			                   
			Console.WriteLine(respsota);
      
			Console.ReadKey(true);
		}
    
	}
  
}
