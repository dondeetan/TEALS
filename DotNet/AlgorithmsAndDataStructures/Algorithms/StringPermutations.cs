using System;
using System.Linq;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class StringPermutations
    {
        
        public StringPermutations(){}
        
        public static void Permutate(string input, int startindex, int endindex){
            
            if (startindex == endindex)
            {
                Console.WriteLine(input);
            }

            // 2nd Base Case input is ABC. The result should be ABC, ACB, BAC, BCA, CAB, CBA
            for (int index = startindex; index <= endindex; index++){
                
                input = swap(input, startindex, index);  

                Permutate(input,startindex + 1, endindex);
                
                input = swap(input, startindex, index);                                                   
            }
        }

        private static string swap(string inputswap, int startindex, int nextindex){
            if (startindex == nextindex)
                return inputswap;
            char[] inputswapchars = inputswap.ToCharArray();
            char temp = inputswapchars[startindex];
            inputswapchars[startindex] = inputswapchars[nextindex];
            inputswapchars[nextindex] = temp;
            var input = new String(inputswapchars);
            return input;
        }
    }
}