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
            int midpoint = ((number * 2) - 1) / 2;
            for (int row = 0; row < twodimensionalarray.GetLength(0); row++)
            {
                //Initialize each row of stairs
                string stairs = "";        
                //Initialize the column
                for (int column = 0; column < twodimensionalarray.GetLength(1); column++)
                {
                    if (midpoint - row <= column && midpoint + row >= column)
                        stairs += "#";
                    //The trick is to make sure that each column matches the row number
                    //If so, use the #
                    else
                        stairs += " ";
                }                     
                Console.WriteLine(stairs);
            }
            return twodimensionalarray;
        }
    }
}