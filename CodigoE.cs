using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira seu nome : ");
		 	string nome = Console.ReadLine();	

			Console.Write("Você é maior de idade? (sim/não) ");
		 	string idade = Console.ReadLine();		 	
		 	
		 	int tamanho = nome.Length;
		 	if (tamanho >= 3 && idade == "sim"){
				Console.WriteLine("Acesso permitido.");
			}
		 	else {
		 		Console.WriteLine("Acesso negado.");
		 	}
			Console.ReadKey(true);
		}
	}
}
