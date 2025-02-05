using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Você quer açúcar ou leite ao seu café? (sim/não) ");
		 	string desejo = Console.ReadLine();		 	
		 	
		 	if (desejo == "sim"){
				Console.WriteLine("afé com adicional pronto");
			}
			Console.ReadKey(true);
		}
    
	}
  
}
