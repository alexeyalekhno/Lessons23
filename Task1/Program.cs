using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);


            Console.ReadKey();


        }

        static void Factorial(int n)
        { 
            int f = 1;
        for (int i = 1; i <= n; i++)
            {
               f  *= i;
                Thread.Sleep(300);
            }
            Console.WriteLine(f);
            

        }


        

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
