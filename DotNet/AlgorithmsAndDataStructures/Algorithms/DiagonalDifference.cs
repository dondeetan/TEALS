using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class DiagonalDifference
    {
        public static int GetDiagonalDifference(List<List<int>> arr)
        {
            var result = 0;
            var diaginal1sum = 0;
            var diaginal2sum = 0;
            var rowcount = 0;
            var columncount = arr.Count-1;
            foreach(var value in arr)
            {
                diaginal1sum += arr[rowcount][rowcount];
                diaginal2sum += arr[rowcount][columncount];
                //Increment diagonal1count
                rowcount++;
                columncount--;
            }
            result = Math.Abs(diaginal1sum - diaginal2sum);
            return result;

        }        
    }
}