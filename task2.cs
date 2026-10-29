/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество студентов: ");
        int students = int.Parse(Console.ReadLine());

        Console.Write("Введите количество предметов: ");
        int subjects = int.Parse(Console.ReadLine());

        int[,] grades = new int[students, subjects];

        for (int i = 0; i < students; i++)
        {
            for (int j = 0; j < subjects; j++)
            {
                Console.Write($"Оценка студента {i + 1} по предмету {j + 1}: ");
                grades[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < students; i++)
        {
            double sum = 0;

            for (int j = 0; j < subjects; j++)
            {
                sum += grades[i, j];
            }

            Console.WriteLine($"Средняя оценка студента {i + 1}: {sum / subjects}");
        }
    }
}
*/