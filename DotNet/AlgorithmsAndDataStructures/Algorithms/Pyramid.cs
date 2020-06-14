using System;
using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class Pyramid
    {
        //Print the following pyramid
        //  "#"
        // "###"
        //"#####"
        public Pyramid(){}

        public static int[,] PrintPyramid(int number){
            //Use 2 Dimensional Array to hold values for # and Empty Spaces
            //Here we multiply the column by the number * 2 then minus 1
            int[,] twodimensionalarray = new int [number,(number * 2) - 1];
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

         public static void PrintStepsRecusion(int number, int row = 0, string stair = ""){
            //This is the base. Make sure that the number (e.g.) is equal to row
            //The base is breaking out of the recursion
            if (number == row)
            {
                return;
            }

            if (number == stair.Length){
                Console.WriteLine(stair);
                //Now we increment the row if the number is equal to the stair lenght or count. 
                //The step below adds the number of the row 
                //As we incrememt row, we'll eventually hit number == row
                PrintStepsRecusion(number, row + 1);      
                return;                          
            }

            //Here we now add the proper # on the stair / row values
            if (stair.Length <= row)
            {
                stair += "#";
            }
            else
            {
                stair += " ";
            }
            //Here's the recurion. We pass:
            //Same number, this doesn't change
            //Same row, this only changes when we hit the condition number == stair.Length
            //Same stair, because we're increasing the stair length because of the condition stair.Length <= row
            PrintStepsRecusion(number, row, stair);
            return;
        }
    }
}