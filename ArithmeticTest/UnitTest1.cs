using NUnit.Framework;
using Arithmetic;

namespace ArithmeticTest
{
    public class Tests
    {
        private Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TestCase(10,20)]
        public void Test1(int a, int b)
        {
            var result = calc.sum(a, b);
            Assert.AreEqual(30,result);
        }
    }
}