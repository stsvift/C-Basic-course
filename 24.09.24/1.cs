using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int N = array.Length;
        int K = 3; // Начало диапазона (индекс 2)
        int L = 6; // Конец диапазона (индекс 5)

        if (K < 1 || L > N || K > L)
        {
            Console.WriteLine("Неверные значения K или L.");
            return;
        }

        K--;
        L--;

        int totalSum = array.Sum();

        int sumExcluded = 0;
        for (int i = K; i <= L; i++)
        {
            sumExcluded += array[i];
        }

        int count = N - (L - K + 1);

        if (count == 0)
        {
            Console.WriteLine("Нет элементов для вычисления среднего.");
            return;
        }

        double average = (double)(totalSum - sumExcluded) / count;

        Console.WriteLine($"Среднее арифметическое: {average:F2}");
    }
}
