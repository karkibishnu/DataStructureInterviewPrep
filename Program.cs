using DataStructureInterviewPrep.DataStructureTypes.Arrays;
using DataStructureInterviewPrep.DataStructureTypes.Dictionary;
using System;
using System.Collections.Generic;

namespace DataStructureInterviewPrep
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //counting words in input string
            string input = "If you can change your mind, you can change your life";
            Dictionary<string, int> wordCounts = WordCounter.CountWords(input);

            foreach (var item in wordCounts)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
                Console.WriteLine();
            }

            //array console 
            ArraysConsole.Array2DExample();

            Console.ReadLine();
        }
    }
}
