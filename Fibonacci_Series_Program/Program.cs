using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Fibonacci_Series_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number Count: ");
            int nCount = Convert.ToInt32(Console.ReadLine());

            int def_0 = 0;
            int def_1 = 1;

            int itt = 1;
            int temp_01 = def_0;
            int temp_02 = def_1;

            List<int> fibonacciNumber = new List<int>();

            do
            {
                int fibbNum = temp_01 + temp_02;
                fibonacciNumber.Add(fibbNum);

                temp_01= fibbNum;

                if (itt > 1)
                {
                    temp_02 = fibonacciNumber[fibonacciNumber.Count - 2];
                }

                itt++;

            } while (itt <= nCount - 2);

            ///Display to User
            foreach(int num in fibonacciNumber)
            {
                Console.Write($"{num} ");
            }

            Console.ReadKey();
        }
    }
}
