using NUnit.Framework;

namespace Homeworks.Tests
{
    public class Variables
    {
        [TestCase(10, 2, -6.75)]
        [TestCase(5, 7, 37)]
        [TestCase(-1, 0, -5)]
        [TestCase(-2, -6, -6.5)]
        [TestCase(0, 3, 3)]
        public void DecideEquation(int a, int b, double expected)
        {
            double actual = Homeworks.Variables.DecideEquation(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 7)]
        [TestCase(0, 0)]
        public void DecideEquationNegative(int a, int b)
        {
            try
            {
                Homeworks.Variables.DecideEquation(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(5, 10)]
        [TestCase(8, -5)]
        [TestCase(0, 2)]
        public void ChangeTwoVariables(ref int a, ref int b)
        {
            int an = a;
            int bn = b;
            Homeworks.Variables.ChangeTwoVariables(ref a, ref b);
            Assert.AreEqual(an, b);
            Assert.AreEqual(bn, a);

        }

        [TestCase(10, 4, 2.5)]
        [TestCase(-5, 8, -0.625)]
        [TestCase(15, -3, -5)]
        [TestCase(0, 8, 0)]
        [TestCase(11, 3, 3.666)]
        public void DevideAByB(int a, int b, double expected)
        {
            double actual = Homeworks.Variables.DevideAByB(a, b);
            double delta = 0.001;
            Assert.AreEqual(expected, actual, delta);
        }

        [TestCase(5,0)]
        [TestCase(8,0)]
        public void DevideAByBNegative(int a, int b)
        {
            try
            {
                Homeworks.Variables.DevideAByB(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(10, 2, 0)]
        [TestCase(8, 9, 8)]
        [TestCase(74, -21, 11)]
        [TestCase(-14, 5, -4)]
        [TestCase(0, 2, 0)]
        [TestCase(-5, -4, -1)]
        public void FindRamainderOfDivision(int a, int b, int expected)
        {
            int actual = Homeworks.Variables.FindRamainderOfDivision(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 0)]
        [TestCase(-8, 0)]
        public void FindRamainderOfDivisionNegative(int a, int b)
        {
            try
            {
                Homeworks.Variables.FindRamainderOfDivision(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(6, 5, 1, -0.666)]
        [TestCase(9, 15, 8, -0.777)]
        [TestCase(-7, 4, -11, 2.142)]
        [TestCase(-9, -2, 84, -9.555)]
        [TestCase(-10, -3, -8, 0.5)]
        [TestCase(-10, 0, 25, -2.5)]
        [TestCase(154, 0, -0, 0)]
        public void DecideLinearEquation(int a, int b, int c, double expected)
        {
            double actual = Homeworks.Variables.DecideLinearEquation(a, b, c);
            double delta = 0.001;
            Assert.AreEqual(expected, actual, delta);
        }

        [TestCase(0, 8, 7)]
        [TestCase(0, 8, 0)]
        [TestCase(0, -9, 1)]
        public void DecideLinearEquationNegative(int a, int b, int c)
        {
            try
            {
                Homeworks.Variables.DecideLinearEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 1, 4, 11, "Y=3,33*X-2,33")]
        [TestCase(9, 5, -9, 3, "Y=0,11*X+4,00")]
        [TestCase(15, -8, -11, -24, "Y=0,62*X-17,23")]
        [TestCase(0, 31, -10, 4, "Y=2,70*X+31,00")]
        [TestCase(0, 17, 2, -7, "Y=-12,00*X+17,00")]
        public void DoEquation(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = Homeworks.Variables.DoEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, 0, -8)]
        [TestCase(95, 5, 95, -8)]
        [TestCase(-6, 17, -6, -41)]
        public void DoEquationNegative(int x1, int y1, int x2, int y2)
        {
            try
            {
                Homeworks.Variables.DoEquation(x1, y1, x2, y2);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}