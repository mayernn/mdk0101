/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Массив в обратном порядке:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }

        double average = sum / n;
        int closest = numbers[0];

        for (int i = 1; i < n; i++)
        {
            if (Math.Abs(numbers[i] - average) < Math.Abs(closest - average))
            {
                closest = numbers[i];
            }
        }

        Console.WriteLine();
        Console.WriteLine("Среднее арифметическое: " + average);
        Console.WriteLine("Ближайшее число: " + closest);
    }
}
*/