using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("insira um número : ");
			float numero = float.Parse(Console.ReadLine());
		 	
		 	if (numero != 0 ){
				Console.WriteLine("O número é diferente de zero.");
				}
			Console.ReadKey(true);
		}
    
	}
  
}
