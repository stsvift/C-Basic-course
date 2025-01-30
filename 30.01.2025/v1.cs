using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите делимое: ");
            string input1 = Console.ReadLine();
            if (string.IsNullOrEmpty(input1))
                throw new Exception("не введено число");
            if (input1.Length > 15)
                throw new Exception("введено слишком длинное число");
            
            Console.Write("Введите делитель: ");
            string input2 = Console.ReadLine();
            if (string.IsNullOrEmpty(input2))
                throw new Exception("не введено число");
            if (input2.Length > 15)
                throw new Exception("введено слишком длинное число");

            if (!double.TryParse(input1, out double num1) || !double.TryParse(input2, out double num2))
                throw new Exception("ошибка преобразования");
            
            if (num2 == 0)
                throw new Exception("деление на ноль");
            
            Console.WriteLine($"Результат: {num1 / num2}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
}
