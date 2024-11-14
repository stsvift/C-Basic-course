using System;
using System.Linq;

class Program
{
    static int MaxSumOfDiagonals(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int maxSum = int.MinValue;

        // Диагонали ниже и включая главную диагональ
        for (int k = 0; k < n; k++)
        {
            int sum = 0;
            for (int i = 0, j = k; i < n && j < n; i++, j++)
                sum += matrix[i, j];
            maxSum = Math.Max(maxSum, sum);
        }

        // Диагонали выше главной диагонали
        for (int k = 1; k < n; k++)
        {
            int sum = 0;
            for (int i = k, j = 0; i < n && j < n; i++, j++)
                sum += matrix[i, j];
            maxSum = Math.Max(maxSum, sum);
        }

        return maxSum;
    }

    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        int maxSum = MaxSumOfDiagonals(matrix);
        Console.WriteLine($"Максимум среди сумм элементов диагоналей, параллельных главной: {maxSum}");
    }
}
