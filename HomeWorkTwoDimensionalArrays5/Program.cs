using System;

//Отразите массив относительно его главной диагонали.

namespace HomeWorkTwoDimensionalArrays5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив данных:");

            int[,] Array = new int[4, 6];
            Random random = new Random();

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = random.Next(100);
                    Console.Write($"{Array[i, j]}  ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(Array[i, j]);
                    }
                }
            }
        }
    }
}
