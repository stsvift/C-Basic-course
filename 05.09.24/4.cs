using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите стороны:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double p = a + b * 2;
        Console.WriteLine($"Периметр прямоугольника равен: {p}");
        double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        Console.WriteLine($"Диагональ прямоугольника равна: {d}");
    }
}   