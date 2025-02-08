using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод количества элементов
        Console.Write("Введите количество элементов в массиве: ");
        int n;

        // Проверка корректности ввода
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Введите корректное положительное число: ");
        }

        double[] numbers = new double[n];

        // Ввод элементов массива
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write($"Ошибка! Введите корректное число для элемента {i + 1}: ");
            }
        }

        // Проверка, является ли массив возрастающим
        bool isIncreasing = IsIncreasing(numbers);

        // Вывод результата
        if (isIncreasing)
        {
            Console.WriteLine("Последовательность является возрастающей.");
        }
        else
        {
            Console.WriteLine("Последовательность не является возрастающей.");
        }
    }

    static bool IsIncreasing(double[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] >= array[i + 1]) // Если текущий элемент не меньше следующего
            {
                return false; // Последовательность не возрастающая
            }
        }
        return true; // Если все проверки пройдены, последовательность возрастающая
    }
}