using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirobLab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Console.Read();
        }

        static void Task1()
        {
            int n = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(n, 16);
            Console.WriteLine(hex);
        }
        static void Task2()
        {
            Console.WriteLine("Enter your numbers: ");
            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            double z = Convert.ToInt32(Console.ReadLine());
            double a = Math.Pow(Math.E, Math.Abs(x - y)) + Math.Log(1+z*z);
            double b = Math.Pow(Math.E, 2 * Math.Abs(x - y)) -0.5*Math.Sqrt(1 + z*z);
            double c = Math.Pow(1 + z * z, 1 / 3) + Math.Pow(Math.E, -Math.Abs(x - y));
            double max = Math.Pow(Math.Max(a, Math.Max(b*b*b, c*c)), 2);
            Console.WriteLine(max);
        }
        static void Task3()
        {
            int[,] arr = new int[5, 6];
            Random rnd = new Random();
            for(int i = 0; i < 5; ++i)
            {
                for(int j = 0; j < 6; ++j)
                {
                    arr[i,j] = rnd.Next(-10, 50);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[] C = new int[5];
            int temp;
            for(int i = 0; i < 5; ++i)
            {
                temp = arr[i, 0];
                for(int j = 1; j < 6; ++j)
                {
                    if(temp < arr[i, j])
                    {
                        temp = arr[i, j];
                    }
                }
                C[i] = temp;
                Console.Write(C[i] + " ");
            }
            int counter = 0;
            temp = C[0];
            for(int i = 1; i < 5; ++i)
            {
                if(temp > C[i])
                {
                    temp = C[i];
                    counter = i;
                }
            }
            Console.WriteLine("\n" + counter);
        }   

    }
}
