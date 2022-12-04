using System;
using System.IO;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            Console.WriteLine(task2(input));
        }
        static int task1(string[] input)
        {
            int totalPrio = 0;

            foreach (string bp in input)
            {
                string[] compartments = new string[2];
                compartments[0] = bp.Substring(0, bp.Length / 2);
                compartments[1] = bp.Substring(bp.Length / 2, bp.Length / 2);

                char doubleItemName;
                int doubleItemValue = 0;
                
                foreach(char c in compartments[0])
                {
                    if (compartments[1].Contains(c))
                    {
                        doubleItemName = c;
                        if (Char.IsUpper(c))
                        {
                            doubleItemValue = c - 38;
                        }
                        else
                        {
                            doubleItemValue = c - 96;
                        }
                        
                    }
                }
                totalPrio += doubleItemValue;
                
            }
            return totalPrio;
        }
        static int task2(string[] input)
        {
            int totalPrio = 0;

            foreach (string bp in input)
            {
                string[] compartments = new string[2];
                compartments[0] = bp.Substring(0, bp.Length / 2);
                compartments[1] = bp.Substring(bp.Length / 2, bp.Length / 2);

                char doubleItemName;
                int doubleItemValue = 0;

                foreach (char c in compartments[0])
                {
                    if (compartments[1].Contains(c))
                    {
                        doubleItemName = c;
                        if (Char.IsUpper(c))
                        {
                            doubleItemValue = c - 38;
                        }
                        else
                        {
                            doubleItemValue = c - 96;
                        }

                    }
                }
                totalPrio += doubleItemValue;

            }
            return totalPrio;
        }
    }
}
