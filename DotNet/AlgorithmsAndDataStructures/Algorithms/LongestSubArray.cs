using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class LongestSubArray
    {
        public LongestSubArray(){         
}
        public static int longestSubarray(List<int> arr)
        {
            //Hold the length of subarray here.
            var lengthofsubarray = 1;
            //Create a dictionary to hold each distinct values 
            var distinctvalueshashtable = new Hashtable();
            var distinctvalueslist = new List<int>();
            //Loop through the array and create a hashset of each values
            //Brute force we'll create 2 different data structures, one to hold the distinct characts using a list so we can easily sort then do a compare 
            // The other is the hastable that contains the number of distinc values
            arr.ForEach(value => {
                if (!distinctvalueshashtable.ContainsKey(value))
                {
                    distinctvalueshashtable.Add(value,1);
                    distinctvalueslist.Add(value);
                }                    
                else 
                {
                    int currentvalue = (int)distinctvalueshashtable[value];                  
                    distinctvalueshashtable[value] = currentvalue + 1;
                }
            }); 
            //Sort the distinct values: 
            distinctvalueslist.Sort();
            for(int i = 0; i < distinctvalueslist.Count -1 ; i++)      
            {
                //Get the current key and values from the hastable
                var valueofdistinctnumber1 = distinctvalueslist[i];
                var valueofdistinctnumber2 = distinctvalueslist[i+1];
                var keycountindex1 = (int) distinctvalueshashtable[valueofdistinctnumber1];
                var keycountindex2 = (int) distinctvalueshashtable[valueofdistinctnumber2];
                var absolutedifference = Math.Abs(valueofdistinctnumber1 - valueofdistinctnumber2);
                //Rule 1: Since the list is sorted, we check the different from the second element to the first and ensure the difference is 1
                // Rule 2: If the key count is greater than 2, then we only add the total length of the subarray by 2
                if (absolutedifference == 1 && (keycountindex1 >= 2 || keycountindex2 >= 2))
                {
                    lengthofsubarray = keycountindex1 + keycountindex2;
                }
                //Rule 3: If the distinct values difference is 1 and the keycount < 2 (no other values of the same key)
                else if (absolutedifference == 1 && (keycountindex1 == 1 || keycountindex2 == 1))
                {
                    //Always set to 2 regardless for distinct keys
                    lengthofsubarray = 2;
                }
            }            
            return lengthofsubarray;
        }    
    }
}