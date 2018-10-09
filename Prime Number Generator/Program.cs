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
            double sqrMax = Math.Sqrt(max);
            int j = 0;
            var nums = Enumerable.Range(0, max).ToList();

            for (int i = 2; i <= sqrMax;)
            {
                if (j == max)
                {
                    i++;
                    j = 0;
                }
                else if (j < max)
                {
                    if (j % i == 0 && j != i)
                    {
                        nums[j] = 0;
                    }
                    j++;
                }
            }
            int x = 0;
            foreach (var k in nums)
            {
                if (k != 0)
                {
                    x++;
                    Console.WriteLine(x +"-"+ k);
                }
            }
        }
    }
}
