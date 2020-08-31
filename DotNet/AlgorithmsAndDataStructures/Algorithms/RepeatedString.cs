using System;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class RepeatedString
    {
        public static long GetRepeatedString(string s, long n) {
            var inputstring = s.ToLower();
            long results = 0;
            //Get the number of repeated strings
            long counttofrepeatedstrings = n / inputstring.Length;
            //Get the remainder of repeated strings
            long remainderofrepeatedstrings = n - (counttofrepeatedstrings * inputstring.Length);
            //Get count of a's
            var countofa = 0;   
            var countofainremainder = 0;
            for (int i = 0; i < inputstring.Length; i++){               
                if (i < remainderofrepeatedstrings && inputstring[i] == 'a')
                {
                    countofainremainder++;
                }
                if (inputstring[i] == 'a')
                {
                    countofa++;
                }
            }   
            if (countofa != 0)         
                results = (countofa * counttofrepeatedstrings) + countofainremainder;
                     
            return results;
        }    
    }
}