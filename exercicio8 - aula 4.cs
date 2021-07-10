using System;

public class Program
{
	public static void Main()
	{
		 int num;
		 Console.WriteLine("Digite o valor do numero: ");
		 num = int.Parse(Console.ReadLine());
		 if(num<0){
		 	Console.WriteLine("O número é negativo");
		 	}
		 	 if  (num>0){
		 		Console.WriteLine("O número é positivo");
		 		}
		    else if(num==0){
		  	Console.WriteLine("O número é neutro(0)");
		  	}
		  	Console.BackgroundColor = ConsoleColor.Purple;
		    Console.ForegroundColor = ConsoleColor.Pink;
		    Console.ReadKey();
		  	
		  	
	}
}
