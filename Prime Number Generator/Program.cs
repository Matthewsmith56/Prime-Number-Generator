using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you would like to find primes up to then press enter");

            int max = (Convert.ToInt32(Console.ReadLine()) - 1);
            int j = 0;
            var nums = Enumerable.Range(2, max).ToList();

            for (int i = 2; i <= max;)
            {
                if (j == max)
                {
                    i++;
                    j = 0;
                }
                else if (j < max)
                {
                    if (nums[j] % i == 0 && nums[j] != i)
                    {
                        nums[j] = 0;
                    }
                    j++;
                }
            }
            foreach (var k in nums)
            {
                if (k != 0)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}
