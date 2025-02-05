using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("você é um robô? ");
			string resposta = Console.ReadLine();
		 	
		 	if (resposta == "não" || resposta == "n" || resposta == "nao")
		 	{
				Console.WriteLine("Verifique que você não é um robô.");
			}
			Console.ReadKey(true);
		}
		
	}
	
}
