using System;
using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class Steps
    {
        public Steps(){}

        public static int[,] PrintSteps(int number){
            //Use 2 Dimensional Array to hold values for # and Empty Spaces
            int[,] twodimensionalarray = new int [number,number];
            //Initialize the row
            for (int row = 0; row < twodimensionalarray.GetLength(0); row++)
            {
                //Initialize each row of stairs
                string stairs = " ";        
                //Initialize the column
                for (int column = 0; column < twodimensionalarray.GetLength(1); column++)
                {
                    string stair = " ";
                    //The trick is to make sure that each column matches the row number
                    //If so, use the #
                    if (column <= row)
                    {
                        stair = "#";
                        stairs += stair;
                    }
                    //Assign emptry string to the rest of the row columns
                    else
                    {
                        stairs += stair;                        
                    }    
                    //Add values to the array to unit test                  
                    twodimensionalarray[row,column] = stair.ToCharArray().FirstOrDefault();
                }                     
                Console.WriteLine(stairs);
            }
            return twodimensionalarray;
        }
    }
}