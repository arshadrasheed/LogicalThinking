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
            Console.Write("Enter Number: ");
            int nCount = Convert.ToInt32(Console.ReadLine());

            int temp_0 = 0;
            int temp_1 = 1;

            List<int> fibonacciNumbers = new List<int>();
            fibonacciNumbers.Add(temp_0);
            fibonacciNumbers.Add(temp_1);

            for (int i = 2; i < nCount; i++)
            {
                int fibNum = temp_0 + temp_1;
                
                fibonacciNumbers.Add(fibNum);

                temp_0=fibNum;
                temp_1 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            }

            foreach (int  number in fibonacciNumbers)
            {
                Console.Write($"{number} ");
            }

            Console.ReadKey();
        }
    }
}
