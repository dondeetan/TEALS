using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class MaxCharacters
    {
        public MaxCharacters(){}
        public static void FindMaxCharacters(string input){
            var dictionary = new Dictionary<char,int>();
            var characters = input.ToCharArray();
            var maxcount = 0;
            char maxchar;  
            foreach(char character in characters){
                if (!dictionary.ContainsKey(character)){
                    dictionary.Add(character, 1);
                }
                else
                {
                    dictionary[character] += 1;
                }
            } 

            foreach(var dictionaryentry in dictionary){
                if (dictionaryentry.Value > maxcount){
                    maxcount = dictionaryentry.Value;
                    maxchar = dictionaryentry.Key;
                }
            }           
        }
    }
}