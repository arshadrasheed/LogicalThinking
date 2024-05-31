using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PallindromeNumber_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            string number = Console.ReadLine();

            string reverseNumber = string.Empty;

            for (int i = number.Length; i > 0; i--)
            {
                reverseNumber = $"{reverseNumber}{number[i-1]}";
            }

            if (reverseNumber == number)
            {
                Console.WriteLine( $"The Entered Number {number} is Pallindrome Number");
            }

            Console.ReadKey();
        }
    }
}
