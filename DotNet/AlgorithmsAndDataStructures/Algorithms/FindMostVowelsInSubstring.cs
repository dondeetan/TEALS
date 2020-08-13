using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class FindMostVowelsInSubstring
    {
         public static string FindSubstring(string s, int k)
        {
            var chararray = s.ToCharArray();
            var stringwithmaxvowels = String.Empty;
            Dictionary<string,int> values = new Dictionary<string, int>();
            for (int i = 0; i < s.Length - (k - 1); i++)
            {
                var endindex = k+i;
                var substring = chararray[i..endindex];
                var countofvalue = 0;
                substring.ToList().ForEach(subchar => {
                   switch (subchar)
                   {
                       case 'a':   
                       case 'e':
                       case 'i':
                       case 'o':
                       case 'u':
                        countofvalue++;
                        break;
                       default:
                        break;
                   }
                });                
                values.Add(new String(substring),countofvalue);
            }
            stringwithmaxvowels = values.OrderByDescending(value => value.Value).FirstOrDefault().Key;
            return stringwithmaxvowels;
        }
    }
}