using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество дней мая: ");
        int days = int.Parse(Console.ReadLine());

        int[] rainfall = new int[days];
        int dryDays = 0;

        Console.WriteLine("Введите количество осадков по дням (первый день — 0):");
        for (int i = 0; i < days; i++)
        {
            Console.Write($"День {i + 1}: ");
            rainfall[i] = int.Parse(Console.ReadLine());

            if (rainfall[i] == 0)
            {
                dryDays++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"Количество первых дней месяца без осадков: {dryDays}");
    }
}
