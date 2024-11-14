using System;

class Program
{
    static void SumOfNonNegativeColumns(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            bool hasNegative = false;
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, j] < 0)
                {
                    hasNegative = true;
                    break;
                }
                sum += matrix[i, j];
            }

            if (!hasNegative)
            {
                Console.WriteLine($"Сумма элементов в столбце {j + 1}: {sum}");
            }
        }
    }

    static void Main()
    {
        int[,] matrix = {
            { 1, 2, -3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        SumOfNonNegativeColumns(matrix);
    }
}
