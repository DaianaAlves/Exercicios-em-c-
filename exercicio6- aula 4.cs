using System;

public class Program
{
	public static void Main()
	{
		int num, mult;
		Console.WriteLine("Digite um número :");
		num = int.Parse(Console.ReadLine());
		mult = num%5;
		if(mult==0){
			Console.WriteLine("O numero "+num+" é multiplo de 5");
			}
			else{
				Console.WriteLine("O numero "+num+" não é multiplo de 5");
				}
				Console.BackgroundColor =   ConsoleColor.Yellow;
		Console.ForegroundColor = ConsoleColor.Black;
		Console.ReadKey(); 
	}
}
