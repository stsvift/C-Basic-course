using System;

// Вариант 7

class Program
{
    static void Main()
    {
        Console.Write("Введите целое положительное число: ");
        string input = Console.ReadLine();
        int sum = 0;

        foreach (char digit in input)
        {
            if (char.IsDigit(digit))
            {
                sum += digit - '0';
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число.");
                return;
            }
        }

        Console.WriteLine($"Сумма цифр: {sum}");
    }
} 
