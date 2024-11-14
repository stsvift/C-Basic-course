using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите вещественное число A: ");
        double A = double.Parse(Console.ReadLine());

        Console.Write("Введите целое число N (>0): ");
        int N = int.Parse(Console.ReadLine());

        double result = 1;
        for (int i = 1; i <= N; i++)
        {
            result *= A;
            Console.WriteLine($"A^{i} = {result}");
        }
    }
}
