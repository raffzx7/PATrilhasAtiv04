using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	

			Console.Write("Você é um membro ativo do clube : ");
			string resposta =Console.ReadLine();
		 	
		 	if (resposta == "nao" || resposta == "não" || resposta == "n" || resposta == "NÃO" ){
				Console.WriteLine("Atualize sua inscrição para continuar usando os benefícios do clube.");
				}
			Console.ReadKey(true);
		}
    
	}
  
}
