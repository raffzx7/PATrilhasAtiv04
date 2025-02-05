using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira uma palavra : ");
			string palavra =Console.ReadLine();
		 	
		 	if (palavra != "" ){
				Console.WriteLine("A palavra não é vazia.");
				}
			Console.ReadKey(true);
		}
    
	}
  
}
