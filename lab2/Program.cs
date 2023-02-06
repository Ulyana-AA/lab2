using System;
using System.Diagnostics.CodeAnalysis;

namespace lab2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Введите число для сравнения: ");
            int digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину двумерного массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[,] mas1 = new int[n, n];
            int[] mas2 = new int[n];
            
            for (int i = 0; i < mas1.GetUpperBound(0) + 1; i++)
            {
                Console.WriteLine($"Введите элементы {i + 1}-ой строки массива: ");
                for (int j = 0; j < mas1.GetUpperBound(1) + 1; j++)
                {
                    mas1[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (mas1[i, j] < digit) sum += mas1[i, j];
                }
                mas2[i] = sum;
                sum = 0;
            }

            for (int i = 0; i < mas2.Length; i++) Console.Write($"{mas2[i]} ");
   
        }
    }
}
