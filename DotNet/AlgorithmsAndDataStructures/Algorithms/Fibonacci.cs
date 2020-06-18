namespace AlgorithmsAndDataStructures.Algorithms
{
    public class Fibonacci
    {
        public Fibonacci(){}

        public static int GetFibonacci(int number){
            
            if (number < 2)
                return number;
            else{
                return GetFibonacci(number - 1) + GetFibonacci(number - 2);                             
            }          
        }
    }
}