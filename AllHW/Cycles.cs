using NUnit.Framework;

namespace Homeworks.Tests
{
    class Cycles
    {
        //AToPowerB

        [TestCase(2, 2, 4)]
        [TestCase(0, 0, 1)]
        [TestCase(5, 0, 1)]
        [TestCase(0, 2, 0)]
        [TestCase(3, 4, 81)]
        [TestCase(-4, 3, -64)]
        public void AToPowerB(int a, int b, int expected)
        {
            int actual = Homeworks.Cycles.AToPowerB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, -1)]
        [TestCase(-5, -2)]
        [TestCase(0, -12)]
        public void AToPowerBNegative(int a, int b)
        {
            try
            {
                Homeworks.Cycles.AToPowerB(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //ShowDevidendFromA

        [TestCase(100, new int[] {0, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(250, new int[] {0, 250, 500, 750, 1000 })]
        [TestCase(370, new int[] {0, 370, 740})]
        [TestCase(666, new int[] {0, 666 })]
        [TestCase(-320, new int[] {0, 320, 640, 960 })]
        public void ShowDevidendFromA(int a, int[] expected)
        {
            int[] actual = Homeworks.Cycles.ShowDevidendFromA(a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShowDevidendFromANegative()
        {
            try
            {
                Homeworks.Cycles.ShowDevidendFromA(0);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //FindAmountNumbers

        [TestCase(10, 3)]
        [TestCase(100, 9)]
        [TestCase(81, 8)]
        [TestCase(150, 12)]
        [TestCase(500, 22)]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        public void FindAmountNumbers(int a, int expected) 
        {
            int actual = Homeworks.Cycles.FindAmountNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        //FindBiggestDevider

        [TestCase(10, 5)]
        [TestCase(99, 33)]
        [TestCase(17, 1)]
        [TestCase(105, 35)]
        [TestCase(-130, 65)]
        public void FindBiggestDevider(int a, int expected)
        {
            int actual = Homeworks.Cycles.FindBiggestDevider(a);
            Assert.AreEqual(expected, actual);
        }

        //FindSummOfNumbersDevidedBySeven

        [TestCase(0, 50, 196)]
        [TestCase(100, 70, 420)]
        [TestCase(0, 7, 7)]
        [TestCase(-30, 5, -70)]
        [TestCase(8, -18, -14)]
        public void FindSummOfNumbersDevidedBySeven(int a, int b, int expected)
        {
            int actual = Homeworks.Cycles.FindSummOfNumbersDevidedBySeven(a, b);
            Assert.AreEqual(expected, actual);
        }

        //FindFibonacci

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(4, 3)]
        [TestCase(7, 13)]
        [TestCase(10, 55)]
        [TestCase(0, 0)]
        public void FindFibonacci(int n, int expected)
        {
            int actual = Homeworks.Cycles.FindFibonacci(n);
            Assert.AreEqual(expected, actual);
        }

        //FindBiggestDeviderTwo

        [TestCase(15, 17, 1)]
        [TestCase(-8, -12, 4)]
        [TestCase(50, 20, 10)]
        [TestCase(-28, 42, 14)]
        [TestCase(0, 16, 16)]
        [TestCase(0, -5, 5)]
        public void FindBiggestDeviderTwo(int a, int b, int expected)
        {
            int actual = Homeworks.Cycles.FindBiggestDeviderTwo(a, b);
            Assert.AreEqual(expected, actual);
        }

        //FindWhoseCube

        [TestCase(27, 3)]
        [TestCase(8, 2)]
        [TestCase(64, 4)]
        [TestCase(1000, 10)]
        [TestCase(1, 1)]
        public void FindWhoseCube(int n, int expected)
        {
            int actual = Homeworks.Cycles.FindWhoseCube(n);
            Assert.AreEqual(expected, actual);
        }

        //FindCountOddNumbers

        [TestCase(874, 1)]
        [TestCase(0, 0)]
        [TestCase(15, 2)]
        [TestCase(-98, 1)]
        [TestCase(1111, 4)]
        public void FindCountOddNumbers(int a, int expected)
        {
            int actual = Homeworks.Cycles.FindCountOddNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        //FindMirrorNumber

        [TestCase(1, 1)]
        [TestCase(80, 8)]
        [TestCase(14, 41)]
        [TestCase(33, 33)]
        [TestCase(987, 789)]
        public void FindMirrorNumber(int a, int expected)
        {
            int actual = Homeworks.Cycles.FindMirrorNumber(a);
            Assert.AreEqual(expected, actual);
        }

        //ShowAmountNumbersWithStrangeCondition

        [TestCase(10, 4)]
        [TestCase(17, 7)]
        [TestCase(22, 11)]
        [TestCase(30, 14)]
        [TestCase(41, 19)]
        public void ShowAmountNumbersWithStrangeCondition(int n, int expected)
        {
            int actual = Homeworks.Cycles.ShowAmountNumbersWithStrangeCondition(n);
            Assert.AreEqual(expected, actual);
        }

        //FindOutSameNumbers

        [TestCase(1584, 1684, true)]
        [TestCase(-479, 64, true)]
        [TestCase(-78, -21, false)]
        [TestCase(0, 800, true)]
        [TestCase(7463, 5858, false)]
        [TestCase(500, 0, true)]
        [TestCase(0, 0, true)]
        public void FindOutSameNumbers(int a, int b, bool expected)
        {
            bool actual = Homeworks.Cycles.FindOutSameNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
