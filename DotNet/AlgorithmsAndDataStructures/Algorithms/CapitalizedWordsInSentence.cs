using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class CapitalizedWordsInSentence
    {
        public CapitalizedWordsInSentence(){}

        public static string CapitalizeWordsinSentence(string defaultsentence){
             var capitalizedwords = new List<string>();
            defaultsentence.Split(' ').ToList().ForEach(word => {
                //Old Way (Not Using Indexer)
                //capitalizedwords.Add(word[0].ToString().ToUpper() + word.Substring(1, word.Length -1));
                //Using Indexers: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
                capitalizedwords.Add(word[0].ToString().ToUpper() + word[1..^0]);
            });
            return String.Join(" ", capitalizedwords);
        }
    }
}