using System.Collections.Generic;

namespace DataStructureInterviewPrep.DataStructureTypes.Dictionary
{
    public static class WordCounter
    {
        public static Dictionary<string, int> CountWords(string input)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            //split input string by space
            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                //remove trailing comma
                string inputToCount = word.TrimEnd(',');

                //checks if wordCounts dictionary already contains the inputToCount as a key
                //inputToCount is the word without any trailing commas
                if (wordCounts.ContainsKey(inputToCount))
                {
                    //increment count if word already exists in dictionary
                    wordCounts[inputToCount]++;
                }
                else
                {
                    //add word to dictionary with a initial count of 1
                    //Add method adds a new key-value pair to the wordsCount dictionary where the key
                    //is the inputToCount as initial value as 1
                    wordCounts.Add(inputToCount, 1);
                }
            }
            return wordCounts;
        }
    }
}
