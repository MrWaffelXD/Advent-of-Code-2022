using System;
using System.Collections.Generic;
using System.IO;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            Console.WriteLine(task1(input));
        }
        static int task1(string[] input)
        {
            int doublePairCounter = 0;
            Dictionary<List<int>, List<int>> pairAreaListFull = new Dictionary<List<int>, List<int>>();
            foreach (string pairString in input)
            {
                string[] pair = pairString.Split(",");

                List<List<int>> pairAreas = new List<List<int>>();

                foreach (string p in pair)
                {
                    string[] areaLimits = p.Split("-");
                    List<int> areas = new List<int>();

                    for(int i = Convert.ToInt32(areaLimits[0]); i <= Convert.ToInt32(areaLimits[1]); i++)
                    {
                        areas.Add(i);
                    }

                    pairAreas.Add(areas);
                }
                pairAreaListFull.Add(pairAreas[0], pairAreas[1]);
            }

            foreach(KeyValuePair<List<int>, List<int>> pair in pairAreaListFull)
            {
                int foundCounter = 0;
                foreach (int area in pair.Key)
                {
                    if (pair.Value.Contains(area))
                    {
                        foundCounter++;
                    }
                }

                if(foundCounter == pair.Key.Count || foundCounter == pair.Value.Count)
                {
                    doublePairCounter++;
                }
            }
            return doublePairCounter;
        }
    }
}
