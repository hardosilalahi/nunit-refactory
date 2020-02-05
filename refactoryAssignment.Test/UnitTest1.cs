using NUnit.Framework;
using refactoryAssignment;
using System.Collections.Generic;
using System.Linq;


namespace refactoryAssignment.Test
{
    public class Tests
    {
        Class1 Testing;

        [SetUp]
        public void Setup()
        {
            Testing = new Class1();
        }

        [Test]
        public void Test1()
        {
            var result = Testing.prompt("lari pagi");
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Test2()
        {
            var result = Testing.grading(30);
            Assert.AreEqual('E', result);
        }

        [Test]
        public void Test3()
        {
            var result = Testing.OddEven(43);
            Assert.AreEqual("Ganjil", result);
        }

        [Test]
        public void Test4()
        {
            var result = Testing.IsLeapYear(1900);
            Assert.AreEqual("Bukan Kabisat", result);
        }

        [Test]
        public void Test5()
        {
            var result = Testing.FilmRating(32);
            Assert.AreEqual("DEWASA", result);
        }

        [Test]
        public void Test6()
        {
            List<int> loopList = new List<int> {4, 5, 6, 7, 8};
            var result = Testing.LoopInRange(4, 8);
            Assert.AreEqual(loopList, result);
        }

        [Test]
        public void Test7()
        {
            var angkaGanjil = new List<int> {1, 3, 5, 7, 9, 11, 13, 15, 17};
            var preResult = Testing.OddNumbers();
            var result = preResult.Take(9);
            Assert.AreEqual(angkaGanjil, result);
        }

        [Test]
        public void Test8()
        {

        }

        [Test]
        public void Test9()
        {
            var result = Testing.ReverseString("saya ingin makan nasi goreng");
            string reversed = "goreng nasi makan ingin saya";
            Assert.AreEqual(reversed, result);
        }

        [Test]
        public void Test10()
        {
            string[] stuff = {"Meja", "Buku", "Topi", "Baju", "Kayu"};
            string[] addedValue = {"Handuk", "Meja", "Buku", "Topi", "Baju", "Kayu", "Celana"};
            var result = Testing.AddToArray(stuff, "Handuk", "Celana");
            Assert.AreEqual(addedValue, result);
        }

    }
}