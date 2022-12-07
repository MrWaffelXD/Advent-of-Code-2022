using System;
using System.IO;

namespace Day_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            Console.WriteLine(task2(input));
        }
        static int task1(string input)
        {

            for (int i = 0; i <= input.Length; i++)
            {
                string currentPick = input;
                currentPick = currentPick.Substring(i, 4);

                bool isUnique = true;

                foreach(char c in currentPick)
                {
                    if(currentPick.Split(c).Length - 1 > 1)
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    return i + 4;
                    break;
                }
            }
            return 0;
        }
        static int task2(string input)
        {

            for (int i = 0; i <= input.Length; i++)
            {
                string currentPick = input;
                currentPick = currentPick.Substring(i, 14);

                bool isUnique = true;

                foreach (char c in currentPick)
                {
                    if (currentPick.Split(c).Length - 1 > 1)
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    return i + 14;
                    break;
                }
            }
            return 0;
        }
    }
}
