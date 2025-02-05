using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	

			Console.Write("insira seu nome: ");
			string nome =Console.ReadLine();
		 	
		 	if (nome == "Gloria" || nome == "Wilson"){
				Console.WriteLine("Bem-vindo(a)");
			}
			Console.ReadKey(true);
		}
    
	}
  
}
