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
                capitalizedwords.Add(word[0].ToString().ToUpper() + word.Substring(1, word.Length -1));
            });
            return String.Join(" ", capitalizedwords);
        }
    }
}