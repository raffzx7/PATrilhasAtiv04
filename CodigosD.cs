using System;
using System.Collections.Generic;

namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	

			Console.Write("Insira uma palavra: ");
			string palavra = Console.ReadLine();
			
			string tamanho = (palavra.Length == 0) ? "\A string está vazia.": "A string não está vazia.";
			                   
			Console.WriteLine(tamanho);

			Console.ReadKey(true);
		}
    
	}
  
}
