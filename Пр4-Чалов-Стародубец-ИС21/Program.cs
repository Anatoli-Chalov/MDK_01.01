using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 0, b = 0, h = 0;

        // Ввод значений a, b и h
        try
        {
            Console.Write("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите шаг h: ");
            h = Convert.ToDouble(Console.ReadLine());

            // Проверка корректности введенных значений
            if (a < -1 || a > 1 || b < -1 || b > 1)
            {
                Console.WriteLine("Значения a и b должны быть в диапазоне [-1, 1] для функции arcsin.");
                return;
            }

            if (h <= 0)
            {
                Console.WriteLine("Шаг h должен быть положительным числом.");
                return;
            }

            // Заголовок таблицы
            Console.WriteLine(" x\t\t F(x)");
            Console.WriteLine("-----------------------");

            // Вычисление значений функции F(x)
            for (double x = a; x <= b; x += h)
            {
                double fx = CalculateF(x);
                Console.WriteLine($"{x:F4}\t {fx:F4}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное значение. Пожалуйста, введите числовые значения.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static double CalculateF(double x)
    {
        // Вычисление значения функции F(x)
        return 6 * Math.Pow(Math.Asin(x), 2) + (1.0 / 3) * x;
    }
}
