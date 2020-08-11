using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class PlusMinus
    {
         public static string plusMult(List<int> SomeList)
        {
            string result = string.Empty;           
            var revenqueue = new Queue<int>();
            var roddqueue = new Queue<int>();

           if (SomeList.Count == 0)
           {
               result = "NEUTRAL";
               return result;
           }
            // Get the list first for each number
            for (int i = 0; i < SomeList.Count(); i++)
            {
                if (i % 2 ==0)
                {
                    revenqueue.Enqueue(SomeList[i]);
                }  
                else
                {                    
                    roddqueue.Enqueue(SomeList[i]);
                }                    
            }   
           
            int revenresult =  GetPlusMinusResults(revenqueue) % 2;
            int roddresult = GetPlusMinusResults(roddqueue) % 2;
            if (roddresult > revenresult)
                result = "ODD";
            else if (roddresult < revenresult)
                result = "EVEN";
            else if (roddresult == revenresult)
                result = "NEUTRAL";
            return result;
        }

        public static int GetPlusMinusResults(Queue<int> filteredqueue){
            //Here I decided to use QUEUE since the rule is *,+,*,+. 
            //Logic implies that any odd index in the queue, we multiply from the previous result
            int countofindexes = filteredqueue.Count;
            int result = 0;         
            //Check the base cases here
            if (countofindexes <= 1)
            {
                result += filteredqueue.Dequeue();
                return result;                          
            }
            for (int i = 0; i < countofindexes; i++)
            {   
                if (i % 2 ==0)
                {
                    result += filteredqueue.Dequeue();
                }
                else
                {
                    result *= filteredqueue.Dequeue();
                }
            }   
            return result;
        }
    }
}