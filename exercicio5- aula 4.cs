using System;

public class Test
{
    public static void Main()
    {
        int num, r;
        Console.WriteLine("Digite o valor do numero");
        num = int.Parse(Console.ReadLine());
        if (num >= 20)
        {
            r = num / 2;
            Console.WriteLine("O numero maior ou igual a 20 agora vale:" + r);
        }
        else
        {
            r = num * 2;
            Console.WriteLine("O numero menor que 20 agora vale:" + r);
        }
        Console.BackgroundColor = ConsoleColor.Pink;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.ReadKey();
    }
}
