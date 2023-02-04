using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPositiveNumbers() 
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.Sum(nums);

            var expected = -100;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_OneNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);

            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_ZeroNumbers()
        {
            var nums = new int[] {  };
            var actual = Summator.Sum(nums);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_BigNumbers()
        {
            var nums = new int[] { 2000000, 2000000, 2000000 };
            var actual = Summator.Sum(nums);

            var expected = 6000000;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_SummatorAvarageTwoPositiveNumbers()
        {
            var nums = new int[] {1, 2 };

            var actual = Summator.Average(nums);

            var expected = 1.5;

            Assert.AreEqual(expected, actual);
        }
        public void Test_SummatorAvarageTwoINTPositiveNumbers()
        {
            var nums = new int[] { 3, 5 };

            var actual = Summator.Average(nums);

            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AssertionsExample()
        {
         // assert BOOLEAN condition
           Assert.That(9 == 9);
            Assert.That(9, Is.GreaterThan(6));

        // Range Assetsions
        double percentage = 99.5;
        Assert.That(percentage, Is.InRange(80, 190));
        Assert.That("I want to become the best QA", Does.Contain("QA"));

            //Regex
            string date = "7/11/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));

            var percentages = new int[] { 10, 30, 50, 100 };
            Assert.That(percentages, Is.All.InRange(0, 100));




        }
    }
}