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
            MaxCharacters.FindMaxCharacters("Hello There!");            
        }
    }
}