using System;
using System.Collections.Generic;
using System.IO;

namespace Prime_Number_Generator
{
    public class Text
    {
        public static void PrintToText(List<int> nums)
        {
            Console.WriteLine("What would you like printed into the text file?" +
                                  "\n1 - Prime Numbers" +
                                  "\n2 - Prime Numbers represented by 0 and X");
            string selection2 = Console.ReadLine();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter writer = new StreamWriter(path + "\\Prime_Output.txt"))
            {
                Console.SetOut(writer);

                if (selection2 == "1")
                {
                    foreach (int k in nums)
                    {
                        if (k != 0)
                        {
                            Console.Write("{0} ", k);
                        }
                    }
                }
                if (selection2 == "2")
                {
                    int numBreak = 0;
                    int sqRoot = Convert.ToInt32(Math.Sqrt(nums.Count));

                    foreach (int k in nums)
                    {
                        if (numBreak % sqRoot == 0)
                        {
                            Console.WriteLine();
                        }
                        if (k != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" X");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else Console.Write(" {0}", k);

                        numBreak++;
                    }
                }
            }

        }
    }
}