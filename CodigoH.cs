using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	

			Console.Write("Você deseja comprar um produto: ");
			string produto =Console.ReadLine();
		 	
			if (produto.ToLower() == "sim")
		 	{
				Console.WriteLine("compra realizada");
			}
			else
			{
				Console.Write("então não compre");
			}
			Console.ReadKey(true);
		}
	}
}
