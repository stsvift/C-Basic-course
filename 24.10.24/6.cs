using System;

class Program
{
    static void SelectionSortOddPositions(int[] A)
    {
        int n = A.Length;
        for (int i = 1; i < n; i += 2)
        {
            int minIdx = i;
            for (int j = i + 2; j < n; j += 2)
                if (A[j] < A[minIdx])
                    minIdx = j;

            // Обмен значений
            (A[i], A[minIdx]) = (A[minIdx], A[i]);
        }
    }

    static void Main()
    {
        int[] A = { 9, 1, 8, 3, 7, 2, 6, 4, 5 };
        SelectionSortOddPositions(A);
        Console.WriteLine(string.Join(", ", A));
    }
}
