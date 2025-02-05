using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("insira um número:");
			int numero = Convert.ToInt32(Console.ReadLine());
		 	
		 	if (numero % 3 == 0 && numero % 5 == 0){
				Console.WriteLine("O número é {0} divisível por 3 e por 5", numero);
			}
			else
			{
				Console.WriteLine("o numero não é divisivel por 3 e 5");
			}
			Console.ReadKey(true);
		}
    
	}
  
}
