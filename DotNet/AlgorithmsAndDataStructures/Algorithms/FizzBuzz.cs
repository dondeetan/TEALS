using System;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class FizzBuzz
    {
        public FizzBuzz(){}

        public static void FindFizzbuzz(int[] intarray){
            foreach (var integer in intarray)
            {
                switch (integer)
                {
                    case int number when (number % 3 == 0 && number % 5 == 0): 
                        Console.WriteLine("FizzBuzz");
                        break;
                    case int number when (integer  % 3 == 0):
                         Console.WriteLine("Fizz");
                         break;
                    case int number when (integer  % 5 == 0):
                         Console.WriteLine("Buzz");
                         break;
                    default:
                        Console.WriteLine(integer);
                        break;
                }   
            }                    
        }
    }
}