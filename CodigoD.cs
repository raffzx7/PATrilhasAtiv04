using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Você é assinante da netflix? (sim/não) ");
		 	string assinatura = Console.ReadLine();	

			Console.Write("Já assistiu Dexter? (sim/não) ");
		 	string serie = Console.ReadLine();		 	
		 		
		 	if (assinatura == "sim" && serie == "sim"){
				Console.WriteLine("Nova temporada es´ta disponvel");
			}
			Console.ReadKey(true);
		}
    
	}
  
}
