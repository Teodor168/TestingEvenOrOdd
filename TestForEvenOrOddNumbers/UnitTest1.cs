using Izpitvane15._10;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Diagnostics.CodeAnalysis;
namespace TestForEvenOrOddNumbers
{
    public class Tests
    {
        static Even num = new Even();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase (1)]
        [TestCase(5)]
        public void TestIsEvenWithOddNumber(int number)
        {
            //arrange
            //Even num = new Even();

            //act
            bool result = num.IsEven(number);

            //assert
            Assert.That(result, Is.False);
        }
        [TestCase(56)]
        public void TestGetEvenWithEvenNumber(int number)
        {
            bool res = num.IsEven(number);

            Assert.That(res, Is.True);
        }
        [TestCase(-6)]
        public void TestIsEvenForNegativeEvenNumber(int number)
        {
            bool res = num.IsEven(number);

            Assert.AreEqual(true, res);
        }
        [TestCase(-5)]
        public void TestIsEvenForNEgativeOddNumber(int number)
        {
            bool reult = num.IsEven(number);
            Assert.AreEqual(false, reult);
        }

        
        [TestCase(0)]
        [TestCase(8)]
        [TestCase(-62)]
        public void TestIsEvenWithThreeEvenNumbers(int number)
        {
            bool res = num.IsEven(number);
            Assert.AreEqual(true, res);
        }
       
        [TestCase  (-1) ]
        [TestCase (-5)]
        [TestCase (-101)]
        public void TestIsEvenWithOddNegaqtiveNumbers(int nums)
        {
            
            bool res = num.IsEven(nums);
            
            
            Assert.That(res, Is.False);
        }

    }
}