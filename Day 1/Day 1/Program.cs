using System;
using System.Collections.Generic;

namespace Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task2();
        }
        static void task1()
        {
            string input = System.IO.File.ReadAllText("input.txt");
            string[] elves = input.Split("\r\n\r\n");

            List<int> totalCaloriesList = new List<int>();

            foreach(string elf in elves)
            {
                string[] rations = elf.Split("\r\n");

                int totalCalories = 0;

                foreach(string ration in rations)
                {
                    if(ration != "")
                    {
                        totalCalories += Convert.ToInt32(ration);
                    }
                }
                totalCaloriesList.Add(totalCalories);
            }
            totalCaloriesList.Sort();
            totalCaloriesList.Reverse();
            Console.WriteLine(totalCaloriesList[0].ToString());
        }
        static void task2()
        {
            string input = System.IO.File.ReadAllText("input.txt");
            string[] elves = input.Split("\r\n\r\n");

            List<int> totalCaloriesList = new List<int>();

            foreach (string elf in elves)
            {
                string[] rations = elf.Split("\r\n");

                int totalCalories = 0;

                foreach (string ration in rations)
                {
                    if (ration != "")
                    {
                        totalCalories += Convert.ToInt32(ration);
                    }
                }
                totalCaloriesList.Add(totalCalories);
            }
            totalCaloriesList.Sort();
            totalCaloriesList.Reverse();

            int totalTopThree = totalCaloriesList[0] + totalCaloriesList[1] + totalCaloriesList[2];
            Console.WriteLine(totalTopThree.ToString());
        }
    }
}
