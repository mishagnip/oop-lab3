using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arrays2DConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Лабораторна робота №3");
            Console.WriteLine("Виконав: Гнип М.В.");
            Console.WriteLine("Завдання №3");
            Console.WriteLine("-----------");
            bool f;
            int n, m, l = 0;
            double min = 12.951, max = -28.305, buf;
            Random rnd = new Random();
            do
            {
                Console.Write("Введiть n: ");
                f = int.TryParse(Console.ReadLine(), out n);
                if (f == false)
                    Console.WriteLine("Помилка! Введенe некоректне значення");
            } while (!f);
            do
            {
                Console.Write("Введiть m: ");
                f = int.TryParse(Console.ReadLine(), out m);
                if (f == false)
                    Console.WriteLine("Помилка! Введенe некоректне значення");
            } while (!f);
            double[, ] arr = new double[n, m];
            double[] minstr = new double[n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.NextDouble() * 100 % (12.951 + 28.305) - 28.305;
                    arr[i, j] = Math.Round(arr[i, j], 3);
                    if (arr[i, j] < min)
                        min = arr[i, j];
                }
                minstr[i] = min;
                min = 12.951;
            }
            PrintArr(arr);
            for (int i = 0; i < minstr.Length; i++)
            {
                Console.WriteLine($"min[{i}] = {minstr[i]}");
                if (minstr[i] > max)
                    max = minstr[i];
            }
            Console.WriteLine($"max = {max}");
            for (int i = 0; i < arr.GetLength(0); i = i + 2)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] < 0)
                    {
                        buf = arr[i, j];
                        for (int k = j; k > l; k--)
                            arr[i, j] = arr[i, j - 1];
                        arr[i, l] = buf;
                        l++;
                    }
                l = 0;
            }
            PrintArr(arr);
            Console.ReadKey();
        }
        static void PrintArr(double[, ] arr)
        {
            for (int i = 0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j<arr.GetLength(1); j++)
                {
                    if (j != arr.GetLength(1) - 1)
                        Console.Write($"{arr[i, j],10}");
                    else
                        Console.WriteLine($"{arr[i, j],10}");
                    }
            }
        }
    }
}
