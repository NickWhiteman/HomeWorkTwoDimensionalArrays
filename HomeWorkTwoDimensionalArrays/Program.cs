using System;

//Найти минимальный элемент массива

namespace HomeWorkTwoDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив данных:");

            int[,] Array = new int[3, 5];
            Random random = new Random();

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = random.Next(20);
                    Console.Write($"{Array[i, j]}  ");
                }
                Console.WriteLine();
            }

            int min = Array[0, 0];

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j] < min)
                    {
                        min = Array[i, j];
                    }
                }
            }

            Console.WriteLine($"Минимальный элемент массива {min}");
        }
    }
}
