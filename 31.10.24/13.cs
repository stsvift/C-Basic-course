using System;
using System.Linq;

class Program
{
    static int[] MergeSortedArrays(int[] A, int[] B)
    {
        int[] C = A.Concat(B).OrderBy(x => x).ToArray();
        return C;
    }

    static void Main()
    {
        int[] A = { 1, 3, 5, 7, 9 };
        int[] B = { 2, 4, 6, 8, 10 };
        int[] C = MergeSortedArrays(A, B);
        Console.WriteLine(string.Join(", ", C)); // Вывод: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    }
}
