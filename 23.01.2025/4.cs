using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для нахождения наибольшего из двух чисел");
        Console.Write("Введите два числа -> ");
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine($"Большее число - {Math.Max(numbers[0], numbers[1])}");
    }
}
