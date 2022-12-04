using System;
using System.IO;

namespace Day_2
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
            int totalScore = 0;

            foreach (string l in input)
            {
                int winLoseScore = 0;
                int choiceValueScore = 0;
                string[] choices = l.Split(" ");

                if (choices[0] == "A")
                {
                    if (choices[1] == "X")//rock vs rock
                    {
                        winLoseScore = 3;
                        choiceValueScore = 1;
                    }
                    if (choices[1] == "Y")//rock vs paper
                    {
                        winLoseScore = 6;
                        choiceValueScore = 2;
                    }
                    if (choices[1] == "Z")//rock vs scissors
                    {
                        winLoseScore = 0;
                        choiceValueScore = 3;
                    }
                }
                else if (choices[0] == "B")
                {
                    if (choices[1] == "X")//paper vs rock
                    {
                        winLoseScore = 0;
                        choiceValueScore = 1;
                    }
                    if (choices[1] == "Y")//paper vs paper
                    {
                        winLoseScore = 3;
                        choiceValueScore = 2;
                    }
                    if (choices[1] == "Z")//paper vs scissors
                    {
                        winLoseScore = 6;
                        choiceValueScore = 3;
                    }
                }
                else if (choices[0] == "C")
                {
                    if (choices[1] == "X")//scissors vs rock
                    {
                        winLoseScore = 6;
                        choiceValueScore = 1;
                    }
                    if (choices[1] == "Y")//scissors vs paper
                    {
                        winLoseScore = 0;
                        choiceValueScore = 2;
                    }
                    if (choices[1] == "Z")//scissors vs scissors
                    {
                        winLoseScore = 3;
                        choiceValueScore = 3;
                    }
                }
                int totalRoundScore = winLoseScore + choiceValueScore;

                totalScore += totalRoundScore;
            }
            return totalScore;
        }
        static int task2(string[] input)
        {
            int totalScore = 0;

            foreach (string l in input)
            {
                int winLoseScore = 0;
                int choiceValueScore = 0;
                string[] choices = l.Split(" ");

                if (choices[0] == "A")//stone
                {
                    if (choices[1] == "X")//lose
                    {
                        //have to use scissors
                        winLoseScore = 0;
                        choiceValueScore = 3;
                    }
                    if (choices[1] == "Y")//draw
                    {
                        //have to use stone
                        winLoseScore = 3;
                        choiceValueScore = 1;
                    }
                    if (choices[1] == "Z")//win
                    {
                        //have to use paper
                        winLoseScore = 6;
                        choiceValueScore = 2;
                    }
                }
                else if (choices[0] == "B")//paper
                {
                    if (choices[1] == "X")//lose
                    {
                        //have to use stone
                        winLoseScore = 0;
                        choiceValueScore = 1;
                    }
                    if (choices[1] == "Y")//draw
                    {
                        //have to use paper
                        winLoseScore = 3;
                        choiceValueScore = 2;
                    }
                    if (choices[1] == "Z")//win
                    {
                        //have to use scissors
                        winLoseScore = 6;
                        choiceValueScore = 3;
                    }
                }
                else if (choices[0] == "C")//scissors
                {
                    if (choices[1] == "X")//lose
                    {
                        //have to use paper
                        winLoseScore = 0;
                        choiceValueScore = 2;
                    }
                    if (choices[1] == "Y")//draw
                    {
                        //have to use scissors
                        winLoseScore = 3;
                        choiceValueScore = 3;
                    }
                    if (choices[1] == "Z")//win
                    {
                        //have to use stone
                        winLoseScore = 6;
                        choiceValueScore = 1;
                    }
                }
                int totalRoundScore = winLoseScore + choiceValueScore;

                totalScore += totalRoundScore;
            }
            return totalScore;
        }
    }
}
