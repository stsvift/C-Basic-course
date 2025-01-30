using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите делимое: ");
            string a = Console.ReadLine();
            if (a == "" || a == null)
                throw new Exception("не введено число");
            if (a.Length > 20)
                throw new Exception("введено слишком длинное число");
            
            Console.Write("Введите делитель: ");
            string b = Console.ReadLine();
            if (b == "" || b == null)
                throw new Exception("не введено число");
            if (b.Length > 20)
                throw new Exception("введено слишком длинное число");
            
            double x = Convert.ToDouble(a);
            double y = Convert.ToDouble(b);
            
            if (y == 0)
                throw new DivideByZeroException("деление на ноль");
            
            Console.WriteLine($"Результат: {x / y}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: ошибка преобразования");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
