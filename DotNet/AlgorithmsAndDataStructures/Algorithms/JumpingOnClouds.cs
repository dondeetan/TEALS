using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class JumpingOnClouds
    {
        // Complete the jumpingOnClouds function below.
        public static int JumpClouds(int[] c) {
            var results = 0;
            //var countofcumulus = 0;
            //index += 2 is essentially juming every 2 clouds 
            for (int index = 0; index < c.Length - 1; index+= 2)
            {   
                //Subtract 1 index because it's a thunder cloud
                if (c[index] == 1)   
                {
                    index--;
                }
                //Add the results if every 2 index is 0;
                results++;
            }
            return results;
        }
    }
}