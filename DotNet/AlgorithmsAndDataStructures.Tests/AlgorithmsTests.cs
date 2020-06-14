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

        [Test]
        public void ValidateSteps_Solution1_ReturnsTrue()
        {
            //Arrange and Act
            int[,] results = Steps.PrintSteps(5);            

            //Assert
            //To assert, we take the two dimensional array value which is the int (decimal) value of the char and compare to the actual character value
            //Row 1 Column 1 = #
            Assert.IsTrue(Convert.ToChar(results[0,0]) == '#');
            //Row 3 Column 3 = #
            Assert.IsTrue(Convert.ToChar(results[2,2]) == '#');
            //Row 2 Column 3 = Empty Space
            Assert.IsTrue(Convert.ToChar(results[1,2]) == ' ');
            //Row 1 Column 2 = Empty Space
            Assert.IsTrue(Convert.ToChar(results[0,1]) == ' ');
        }

         [Test]
        public void  ValidateSteps_Solution2_ReturnsTrue()
        {
             Steps.PrintStepsRecusion(5);
        }

        [Test,Category("PlaceHolder")]
        public void Placeholder()
        {
            Pyramid.PrintPyramid(3);
        }
    }
}