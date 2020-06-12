using System;
using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class ChunkArray
    {
        public ChunkArray(){}

        public static String[][] ChunkArrays(int chunknumber){
            string[] items = Enumerable.Range(1, 100).Select(i => "Item" + i).ToArray();
            // split on groups with each 100 items using jagged arrays
            String[][] chunks = items
                                .Select((stringvalue, index) => new { Value = stringvalue, Index = index })
                                .GroupBy(group => group.Index / chunknumber)
                                .Select(chunk => chunk.Select(x => x.Value).ToArray())
                                .ToArray();

            return chunks;
        }
    }
}