using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ReverseNumber_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while (number > 0)
            {
                int remainder= number % 10;

                reverse = (reverse * 10) + remainder;

                number= number/ 10;
            }

            Console.Write(reverse);
            Console.ReadKey();

        }
    }
}
