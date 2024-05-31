using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PrimeNumber_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Prime Number Count: ");
            int nCount = Convert.ToInt32(Console.ReadLine());

            List<int> primeNumber = new List<int>();

            for (int i = 2; i <= nCount; i++)
            {
                int count = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    primeNumber.Add(i);
                }
            }

            foreach (int number in primeNumber)
            {
                Console.WriteLine(number);
            }


            Console.ReadKey();
        }
    }
}
