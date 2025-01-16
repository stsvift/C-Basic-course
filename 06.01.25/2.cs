using System;
using System.Linq;

// Вариант 7

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
        {
            Console.WriteLine("Ошибка: строка не содержит слов.");
            return;
        }

        string shortest = words.OrderBy(w => w.Length).First();
        string longest = words.OrderByDescending(w => w.Length).First();

        Console.WriteLine($"Самое короткое слово: {shortest}");
        Console.WriteLine($"Самое длинное слово: {longest}");
    }
}
