using NUnit.Framework;
using AlgorithmsAndDataStructures.Algorithms;
using System;
using System.Linq;

namespace AlgorithmsAndDataStructures.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void VValidateReversString_Solution1_ReturnsMaxCharacters()
        {
            //Arrange and Act
            var results = MaxCharacters.FindMaxCharacters("Hello There!");

            //Assert
            Assert.IsTrue(results.Item1 == 'e');
            Assert.IsTrue(results.Item2 == 3);             
        }

        [Test]
        public void ValidateReversString_Solution2_ReturnsRevereString()
        {
            //Arrange and Act
            var results = ReversString.ReverseStringSolution1("apple");

            //Assert
            Assert.IsTrue(results == "elppa");            
        }

        [Test]
        public void ValidateReversString_Solution1_ReturnsRevereString()
        {
            //Arrange and Act
            var results = ReversString.ReverseStringSolution1("apple");

            //Assert
            Assert.IsTrue(results == "elppa");            
        }

         [Test]
        public void ValidateFizzBuzz_Solution1_PrintsFizzBuzz()
        {
            //Arrange and Act
            int[] intarray = new int[50];
            for (int i = 0; i < intarray.Length ; i++)
            {
                intarray[i] = i + 1;
            }            
            FizzBuzz.FindFizzbuzz(intarray);           
        }

          [Test]
        public void ValidateChunkArray_Solution1_ReturnsNChunks()
        {
            //Arrange and Act
            // split on groups with each 100 items
            String[][] chunks = ChunkArray.ChunkArrays(10);

            for (int i = 0; i < chunks.Length; i++)
            {
                foreach (var item in chunks[i])
                    Console.WriteLine($"chunk:{i} {item}");
            }     

            //Assert
            // With 100 items and chunknumber (n) of 10, the result should be 10 chunks
            Assert.IsTrue(chunks.Length == 10);
        }
    }
}