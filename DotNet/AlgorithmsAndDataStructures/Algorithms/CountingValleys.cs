using System;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class CountingValleys
    {
        public static int CountValleys(int n, string s) {
            var result = 0;
            var stepup = 0;
            foreach(var step in s.ToLower().ToCharArray()){
                switch (step)
                {
                    case 'u':
                        stepup++;
                        break;
                    case 'd':
                        if (stepup == 0)            
                        {
                            result++;
                        }
                        stepup--;                        
                        break;
                    default:
                        break;
                }    
            }            
            return result;
        }
    }
}
