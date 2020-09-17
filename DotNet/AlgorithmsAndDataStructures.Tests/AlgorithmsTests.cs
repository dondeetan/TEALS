using NUnit.Framework;
using AlgorithmsAndDataStructures.Algorithms;
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

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

        [Test]
        public void ValidateSprialMatrix_Solution1_ReturnsTrue()
        {
            //Arrange
            int matrixcount = 5;
           
            //Act
            var spiralmatrix = SpiralMatrix.GenerateSpiralMatric(matrixcount);

            //Assert
            //Print Values:
            for (int row = 0; row < spiralmatrix.GetLength(0); row++)
            {                 
                //Initialize the column
                for (int column = 0; column < spiralmatrix.GetLength(1); column++)
                {
                  Console.Write($"\t{spiralmatrix[row,column]}");
                }                     
                Console.WriteLine();            
            }
            Assert.IsTrue(spiralmatrix[2,2] == 25);
        }

        [Test]
        public void ValidateFibonacci_Solution1_ReturnsTrue()
        {
            //
            int fibonaccinumber = 6;

            //Arrange and Act
            var results = Fibonacci.GetFibonacci(fibonaccinumber);

            //Assert
            Assert.IsTrue(results == 8);
        }

          // dotnet test -v n --filter TestCategory=PlaceHolder
        [Test]
        public void StringPermutations_Solution1_ReturnsTrue()
        {
            //Arrange
            string input = "ABC";
           
            //Act and Assert
            StringPermutations.Permutate(input,0,input.Length - 1);

        }

        [Test]
        public void PlusMinus_Solution1_ReturnsTrue()
        {
            //Arrange
             var test = new List<int>{1,3,5,7,9,11,13,15,17,19};
           
            //Act
            var results = PlusMinus.plusMult(test);

            //Assert
            Assert.IsTrue(results == "NEUTRAL");
        }

        [Test]
        public void StringCompareEdits_Solution1_ReturnsTrue()
        {
            //Arrange
            string input1 = "place";
            string input2 = "plce";
           
            //Act
            var results = StringCompareEdits.IsEdit(input1,input2);

            //Assert
            Assert.IsTrue(true);
        }

        [Test]
        public void LongestSubArray_Solution1_ReturnsTrue()
        {
            //Test Case 1  
            var test1 = new List<int>{1,1,1,3,3,2,2};
            //Test Case 2
            var test2 = new List<int>{1,2,1,2};
            //Test Case 3
            var test3 = new List<int>{1,2,3,4,5};

            var result = LongestSubArray.longestSubarray(test1);

        }

        [Test]
        public void CountOfVowels_Solution1_ReturnsTrue()
        {
            //Test Case 1  
            //input azerdii  k = 5
            //output = erdii

            //azerd = 2 vowels
            //zerdi = 2 vowels
            //erdii  = 3 vowels

            //Arrange
            var input = "azerdii";

            //Act
            var results = FindMostVowelsInSubstring.FindSubstring(input, 5);

            //Assert
            Assert.IsTrue(results == "erdii");
        }

         // dotnet test -v n --filter TestCategory=PlaceHolder
        [Test]
        public void SockMerchant_Solution1_ReturnsTrue()
        {

            //Arrange
            var input = new int[] {1,2,1,2,1,3,2};

            //Act
            var results = SockMerchant.GetSockMerchant(input);

            //Assert
            Assert.IsTrue(results == 2);
        }

         // dotnet test -v n --filter TestCategory=PlaceHolder
        [Test]
        public void CountingValley_Solution1_ReturnsTrue()
        {

            //Arrange
            //var input = "UDDDUDUU";
            //Test Case 2: 
            var input2 = "DDUDUDDUDDUDDUUUUDUDDDUUDDUUDDDUUDDUUUUUUDUDDDDUDDUUDUUDUDUUUDUUUUUDDUDDDDUDDUDDDDUUUUDUUDUUDUUDUDDD";

            //Act
            var results = CountingValleys.CountValleys(input2.Length,input2);
            //Assert
            Assert.IsTrue(results == 5);
        }

        [Test]
        public void JumpingOnClouds_Solution1_ReturnsTrue()
        {

            //Arrange
            var input1 = new int[]{0,0,0,1,0,0}; // 3
            var input2 = new int[]{0, 0, 1, 0, 0, 1, 0}; // 4


            //Act
            var results = JumpingOnClouds.JumpClouds(input2);
            //Assert
            Assert.IsTrue(results == 3);
        }

        
        [Test]
        public void RepeatedString_Solution1_ReturnsTrue()
        {

            //Arrange
            var input1 = "abcac";
            //var input = "aba";


            //Act
            var results = RepeatedString.GetRepeatedString(input1,10);
            //Assert
            Assert.IsTrue(results == 4);
        }

        // dotnet test -v n --filter TestCategory=PlaceHolder
        [Test,Category("PlaceHolder")]
        public void DiagonalDifference_Solution1_ReturnsTrue()
        {

            //Arrange
            var input1 = new List<List<int>>();
            //var input = "aba";
            input1.Add(new List<int>{11, 2, 4});
            input1.Add(new List<int>{4, 5, 6});
            input1.Add(new List<int>{10, 8, -12});



            //Act
            var results = DiagonalDifference.GetDiagonalDifference(input1);
            //Assert
            Assert.IsTrue(results == 15);
        }
    }
}