using System;

class Program
{
    static void SortPositiveElements(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        // Сбор положительных элементов в список
        var positiveElements = new List<double>();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (matrix[i, j] > 0)
                    positiveElements.Add(matrix[i, j]);

        // Пузырьковая сортировка
        for (int i = 0; i < positiveElements.Count - 1; i++)
            for (int j = 0; j < positiveElements.Count - i - 1; j++)
                if (positiveElements[j] > positiveElements[j + 1])
                    (positiveElements[j], positiveElements[j + 1]) = (positiveElements[j + 1], positiveElements[j]);

        // Вывод отсортированных положительных элементов
        Console.WriteLine("Отсортированные положительные элементы:");
        Console.WriteLine(string.Join(", ", positiveElements));
    }

    static void Main()
    {
        double[,] matrix = {
            { 3.5, -1.2, 4.3 },
            { -7.8, 6.1, -2.9 },
            { 1.0, 9.3, -4.2 }
        };
        SortPositiveElements(matrix);
    }
}
