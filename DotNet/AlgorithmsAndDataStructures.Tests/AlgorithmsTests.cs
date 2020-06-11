using NUnit.Framework;
using AlgorithmsAndDataStructures.Algorithms;

namespace AlgorithmsAndDataStructures.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidateFindMaxCharacters()
        {
            var results = MaxCharacters.FindMaxCharacters("Hello There!");
            Assert.IsTrue(results.Item1 == 'e');
            Assert.IsTrue(results.Item2 == 3);             
        }
    }
}