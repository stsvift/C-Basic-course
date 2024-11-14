using System;
using System.Linq;

class Program
{
    static int[] CreateSumArray(int[] A)
    {
        int N = A.Length;
        int[] B = new int[N];
        for (int k = 0; k < N; k++)
        {
            B[k] = A.Skip(k).Sum();
        }
        return B;
    }

    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5 };
        int[] B = CreateSumArray(A);
        Console.WriteLine(string.Join(", ", B)); // Вывод: 15, 14, 12, 9, 5
    }
}
