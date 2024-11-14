using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массивов N: ");
        int N = int.Parse(Console.ReadLine());

        int[] A = new int[N];
        int[] B = new int[N];
        int[] C = new int[N];

        Console.WriteLine("Введите элементы массива A:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"A[{i}] = ");
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите элементы массива B:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"B[{i}] = ");
            B[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            C[i] = Math.Max(A[i], B[i]);
        }

        Console.WriteLine("Массив C (максимальные элементы из A и B):");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"C[{i}] = {C[i]}");
        }
    }
}
