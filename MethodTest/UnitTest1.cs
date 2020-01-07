using NUnit.Framework;
using Fungsi;
using System.Collections.Generic;

namespace MethodTest
{
    class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("luthfi halim")]
        public void TestJumlahKarakter(string input)
        {
            var output = Method.JumlahKarakter(input);
            Assert.AreEqual(12, output);
        }
        [TestCase(95)]
        public void TestGrade(int input)
        {
            var output = Method.grade(input);
            Assert.AreEqual('A', output);
        }
        [TestCase(1032)]
        public void TestGanjilGenap(int input)
        {
            var output = Method.ganjilgenap(input);
            Assert.AreEqual("Genap", output);
        }
        [TestCase(1032)]
        public void TestKabisat(int input)
        {
            var output = Method.kabisat(input);
            Assert.AreEqual("Kabisat", output);
        }
        [TestCase(15)]
        public void TestFilmRating(int input)
        {
            var output = Method.filmRating(input);
            Assert.AreEqual("REMAJA", output);
        }
        [TestCase(4, 8)]
        public void TestLoopWithRange(int input1, int input2)
        {
            var output = Method.loop_with_range(input1, input2);
            Assert.AreEqual(new List<int>() { 4, 5, 6, 7, 8 }, output);
        }
        [TestCase(20)]
        public void TestOddInRange(int input)
        {
            var output = Method.oddinrange(input);
            Assert.AreEqual(new List<int>() { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, output);
        }
        [TestCase(5)]
        public void TestGanjilGenapKelipatan(int input)
        {
            var output = Method.ganjil_genap_kelipatan(input);
            Assert.AreEqual(new List<string>() { "0. Bilangan Nol", "1. Ganjil", "2. Genap", "3. Ganjil", "4. Genap" }, output);
        }
        [TestCase("luthfi halim suka makan nasi goreng")]
        public void TestMembalikKataDalamKalimat(string input)
        {
            var output = Method.reverse_word(input);
            Assert.AreEqual("goreng nasi makan suka halim luthfi", output);
        }
        [TestCase("handuk", new string[]{"meja", "kayu", "kursi"},"vacation")]
        public void TestAddToArray(string input1,string[] input2,string input3)
        {
            var output = Method.add_to_array(input1,input2,input3);
            Assert.AreEqual(new List<string>(){ "handuk","meja","kayu","kursi","vacation"}, output);
        }
    }
}