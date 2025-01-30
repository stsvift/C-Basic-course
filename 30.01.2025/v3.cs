using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите делимое: ");
            string s1 = Console.ReadLine();
            Console.Write("Введите делитель: ");
            string s2 = Console.ReadLine();

            if (s1.Length == 0 || s2.Length == 0)
                throw new Exception("не введено число");
            if (s1.Length > 10 || s2.Length > 10)
                throw new Exception("введено слишком длинное число");

            double d1 = double.Parse(s1);
            double d2 = double.Parse(s2);
            
            if (d2 == 0)
                throw new Exception("деление на ноль");
            
            Console.WriteLine($"Результат: {d1 / d2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: ошибка преобразования");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
