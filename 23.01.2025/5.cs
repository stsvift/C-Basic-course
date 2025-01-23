using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа нахождения количества положительных чисел");
        Console.Write("Введите шесть чисел с клавиатуры -> ");
        int count = Console.ReadLine().Split().Select(int.Parse).Count(x => x > 0);
        Console.WriteLine($"Количество положительных чисел в наборе - {count}");
    }
}
