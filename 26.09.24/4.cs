using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива N: ");
        int N = int.Parse(Console.ReadLine());

        int[] A = new int[N];
        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < N; i++)
        {
            Console.Write($"A[{i}] = ");
            A[i] = int.Parse(Console.ReadLine());
        }

        List<int> uniqueElements = new List<int>();
        HashSet<int> seenElements = new HashSet<int>();

        foreach (int element in A)
        {
            if (!seenElements.Contains(element))
            {
                uniqueElements.Add(element);
                seenElements.Add(element);
            }
        }

        Console.WriteLine("Массив без повторяющихся элементов:");
        foreach (int element in uniqueElements)
        {
            Console.Write(element + " ");
        }
    }
}
