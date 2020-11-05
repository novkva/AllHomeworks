using NUnit.Framework;


namespace Homeworks.Tests
{
    class Conditions
    {
        //CheckAndCountTwoVariables

        [TestCase(8, 5, 13)]
        [TestCase(0, -9, -9)]
        [TestCase(4, -19, -15)]
        public void CheckAndCountTwoVariablesPlus(int a, int b, int expected)
        {
            int actual = Homeworks.Conditions.CheckAndCountTwoVariables(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 10, -5)]
        [TestCase(1, 978, -977)]
        [TestCase(-49, 0, -49)]
        public void CheckAndCountTwoVariablesMinus(int a, int b, int expected)
        {
            int actual = Homeworks.Conditions.CheckAndCountTwoVariables(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5, 25)]
        [TestCase(0, 0, 0)]
        [TestCase(-8, -8, 64)]
        public void CheckAndCountTwoVariablesMultiply(int a, int b, int expected)
        {
            int actual = Homeworks.Conditions.CheckAndCountTwoVariables(a, b);
            Assert.AreEqual(expected, actual);
        }

        // FindQuarter

        [TestCase(5, -9, "IV")]
        [TestCase(8, 1, "I")]
        [TestCase(-15, -66, "III")]
        [TestCase(-26, 47, "II")]
        [TestCase(156, -11, "IV")]
        [TestCase(-3, 38, "II")]
        public void FindQuarter(int x, int y, string expected)
        {
            string actual = Homeworks.Conditions.FindQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, -66)]
        [TestCase(-26, 0)]
        [TestCase(0, 0)]
        [TestCase(0, 38)]
        public void FindQuarterNegative(int x, int y)
        {
            try 
            { 
                Homeworks.Conditions.FindQuarter(x, y); 
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        // SortToUp

        [TestCase(8, 9, -5, new int[] { -5, 8, 9 })]
        [TestCase(0, 98, 14, new int[] { 0, 14, 98 })]
        [TestCase(654, 11, 11, new int[] { 11, 11, 654 })]
        [TestCase(0, 1, 2, new int[] { 0, 1, 2 })]
        [TestCase(14, -88, 228, new int[] { -88, 14, 228 })]
        [TestCase(36, -36, 0, new int[] { -36, 0, 36 })]
        [TestCase(24, 42, 24, new int[] { 24, 24, 42 })]
        public void SortToUp(int a, int b, int c, int[] expected)
        {
            int[] actual = Homeworks.Conditions.SortToUp(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //SolveQuadroEquation

        [TestCase(8, 3, -1, new double[] {0.21, -0.59 })]
        [TestCase(-6, 8, 2, new double[] {-0.22, 1.55 })]
        [TestCase(2, 14, 7, new double[] {-0.54, -6.46 })]
        [TestCase(1, 5, 6, new double[] {-2, -3 })]

        [TestCase(3, -18, 27, new double[] {3 })]
        [TestCase(16, -8, 1, new double[] {0.25 })]
        [TestCase(1, 6, 9, new double[] {-3 })]
        [TestCase(18, 12, 2, new double[] {-0.33 })]

        [TestCase(2, 5, 4, new double[] {})]
        [TestCase(6, -2, 13, new double[] {})]
        [TestCase(-7, 1, -10, new double[] {})]
        [TestCase(-9, -9, -4, new double[] {})]
        public void SolveQuadroEquation(int a, int b, int c, double[] expected)
        {
            double[] actual = Homeworks.Conditions.SolveQuadroEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //WriteNumber

        [TestCase(10, "Десять")]
        [TestCase(18, "Восемнадцать")]
        [TestCase(30, "Тридцать")]
        [TestCase(42, "Сорок два")]
        [TestCase(71, "Семьдесят один")]
        [TestCase(88, "Восемьдесят восемь")]
        public void WriteNumber(int number, string expected)
        {
            string actual = Homeworks.Conditions.WriteNumber(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
