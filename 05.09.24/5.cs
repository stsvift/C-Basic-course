using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите внешний радиус:");
        double R = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите внутренний радиус:");
        double r = double.Parse(Console.ReadLine());
        double s = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2));
        Console.WriteLine($"Площадь окружности равна: {s}");
    }
}   