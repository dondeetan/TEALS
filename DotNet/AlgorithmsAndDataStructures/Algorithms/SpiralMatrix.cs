namespace AlgorithmsAndDataStructures.Algorithms
{
    public class SpiralMatrix
    {
        public SpiralMatrix(){}

        public static int[,] GenerateSpiralMatric(int matrixcount)
        {
             int[,] spiralmatrix = new int[matrixcount,matrixcount];
            int startrow = 0;
            int endrow = matrixcount - 1;
            int startcolumn = 0;
            int endcolumn = matrixcount - 1;
            int values = 1;

            while(startcolumn <= endcolumn && startcolumn <= endrow){                
                //First Iteration: Iterate for the first row ascending
                for (int i = startcolumn; i <= endcolumn ; i++)
                {
                    spiralmatrix[startrow,i] = values;
                    values++;
                }
                startrow++;
                //Second Iteration: Iterate for the last column for each row down ascending
                for (int i = startrow; i <= endrow ; i++)
                {
                    spiralmatrix[i,endcolumn] = values;
                    values++;
                }
                endcolumn--;
                //3rd Iteration: Iteration for the last row from last column descending
                for (int i = endcolumn ; i >= startcolumn ; i--)
                {
                    spiralmatrix[endrow,i] = values;
                    values++;                
                }
                endrow--;

                //4th Iteration: Iteration for the first column from first column up ascending
                for (int i = endrow ; i >= startrow ; i--)
                {
                    spiralmatrix[i,startcolumn] = values;
                    values++;
                }
                startcolumn++;
                
            }

            return spiralmatrix;
        }
        
    }
}