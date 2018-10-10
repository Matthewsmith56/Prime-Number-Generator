using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the prime number generator. How would you like to generate primes? " +
                              "\n1 - Generate and list primes within a range of numbers" +
                              "\n2 - Generate primes as X and composite numbers as 0 to visually display distribution within a range of numbers");

            string selection = Console.ReadLine();

            Console.WriteLine("Enter the number you would like to find primes up to");

            int max = (Convert.ToInt32(Console.ReadLine()) - 1);
            double sqrMax = Math.Sqrt(max);
            int j = 2;
            List<int> nums = Enumerable.Range(0, max).ToList();

            for (int i = 2; i <= sqrMax;)
            {
                if (j == max)
                {
                    i++;
                    j = 0;
                }
                else if (j < max)
                {
                    if (j % i == 0 && j != i || j == 1)
                    {
                        nums[j] = 0;
                    }
                    j++;
                }
            }
            if (selection == "1")
            {
                Numeric.NumericPrimes(nums);
            }
            else if (selection == "2")
            {
                Visual.VisualPrimes(nums);
            }
        }
    }
}
