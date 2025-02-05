using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("insira um número: ");
			float numero = Convert.ToSingle (Console.ReadLine());
		 	
		 	if (numero > 10 || numero < 0){
				Console.WriteLine("número não existente.");
			}
			else
			{
				Console.WriteLine("número válido");
			}
			  Console.ReadKey(true);
		}
		
	}
	
}
