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
        public void VValidateReversString_Solution1_ReturnsMaxCharacters()
        {
            var results = MaxCharacters.FindMaxCharacters("Hello There!");
            Assert.IsTrue(results.Item1 == 'e');
            Assert.IsTrue(results.Item2 == 3);             
        }

        [Test]
        public void ValidateReversString_Solution2_ReturnsRevereString()
        {
            var results = ReversString.ReverseStringSolution1("apple");
            Assert.IsTrue(results == "elppa");            
        }

        [Test]
        public void ValidateReversString_Solution1_ReturnsRevereString()
        {
            var results = ReversString.ReverseStringSolution1("apple");
            Assert.IsTrue(results == "elppa");            
        }
    }
}