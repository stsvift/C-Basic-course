using System;

class Program
{
    static void InsertionSortRange(int[] A, int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            int key = A[i];
            int j = i - 1;
            while (j >= start && A[j] > key)
            {
                A[j + 1] = A[j];
                j--;
            }
            A[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] A = { 7, 3, 5, 2, 1, 4, 9, 6, 8, 0, 12, 11, 10, 13, 15, 14 };
        InsertionSortRange(A, 2, 14);
        Console.WriteLine(string.Join(", ", A));
    }
}
