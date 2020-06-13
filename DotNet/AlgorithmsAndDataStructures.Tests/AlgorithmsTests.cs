using NUnit.Framework;
using AlgorithmsAndDataStructures.Algorithms;
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

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

        [Test]
        public void ValidateAnagrams_Solution1_ReturnsTrue()
        {
            //Arrange and Act
            string sentence = "hello there my dear";        
            var results = CapitalizedWordsInSentence.CapitalizeWordsinSentence(sentence);

            //Assert
            Assert.IsTrue(results == "Hello There My Dear");
        }

        [Test,Category("PlaceHolder")]
        public void Placeholder()
        {
            string[] words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            }; 
            Console.WriteLine($"The last word is {words[^1]}");
        }
    }
}