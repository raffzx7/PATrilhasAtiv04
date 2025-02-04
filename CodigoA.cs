using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("insira sua idade: ");
			int idade = int.Parse(Console.ReadLine());
			
			Console.Write("você tem carteira de motorista? (sim/não) ");
			string carteira = Console.ReadLine().ToLower();
       
      if   (idade >= 18 && carteira == "sim")
      		{
      		Console.WriteLine("Você pode dirigir!");
      		}
      else
      		Console.Write("voce não pode dirigir");
      			Console.ReadKey(true);
       }
      
	}
	
}
