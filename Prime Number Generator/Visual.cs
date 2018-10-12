using System;
using System.Collections.Generic;

namespace Prime_Number_Generator
{
    public class Visual
    {
        public static void VisualPrimes(List<int> nums)
        {
            foreach (int k in nums)
            {
                if (k != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("X");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.Write(k);
            }
        }
    }
}


        
