
public class Program
{
    public static void Main()
    {
        double salario, empres, r;
        Console.WriteLine("Digite o valor de seu salario :");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do emprestimo: ");
        empres = double.Parse(Console.ReadLine());
        r = empres * 1.30;
        if (r < salario)
        {
            Console.WriteLine("A prestação corresponde a regra de emprestimos, já pode  retirar seu emprestimo ");
        }
        else
        {
            Console.WriteLine("A prestação não corresponde com a regra de emprestimos,por favor tente um valor menor ao digitado anteriormente");
        }
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.ReadKey();
    }
}
