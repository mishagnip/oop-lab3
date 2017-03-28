using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1DConsole
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
            Console.WriteLine("Завдання №1");
            Console.WriteLine("-----------");
            bool f;
            int n, k=0;
            double sum = 0;
            Random rnd = new Random();
            do
            {
                Console.Write("Введiть n: ");
                f = int.TryParse(Console.ReadLine(), out n);
                if (f == false)
                    Console.WriteLine("Помилка! Введенe некоректне значення");
            } while (!f);
            double[] arr = new double[n];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.NextDouble() * 100 % (53.3 + 15.6) - 15.6;
                arr[i] = Math.Round(arr[i],1);
                Console.WriteLine($"{arr[i]}");
                if (arr[i] * 10 % 10 >= 5 || arr[i] * 10 % 10 <= -5)
                {
                    sum = sum + Math.Abs(arr[i]);
                    k++;
                }
            }
            Console.WriteLine($"sum = {sum}");
            double[] arr2 = new double[n-k];
            k = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] * 10 % 10 < 5 && arr[i] * 10 % 10 >= 0 || arr[i] * -10 % 10 < 5 && arr[i] * -10 % 10 >= 0)
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }
            Array.Sort(arr2);
            Array.Reverse(arr2);
            for (int i = 0; i < arr2.Length; i++)
                Console.WriteLine($"{arr2[i]}");
            Console.ReadKey();
        }
    }
}
