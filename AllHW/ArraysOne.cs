using NUnit.Framework;
using System;

namespace Homeworks.Tests
{
    class ArraysOne
    {
        [TestCase("easyArray1", -88)]
        [TestCase("easyArray2", -4741)]
        [TestCase("easyArray3", -9734)]
        [TestCase("easyArray4", 5)]
        [TestCase("easyArray5", -95)]
        public void FindMinValue(string name, int expected)
        {
            int[] array = GetArrayMock(name);
            int actual = Homeworks.ArraysOne.FindMinValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("easyArray1", 100)]
        [TestCase("easyArray2", 1251)]
        [TestCase("easyArray3", 777)]
        [TestCase("easyArray4", 92)]
        [TestCase("easyArray5", -8)]
        public void FindMaxValue(string name, int expected)
        {
            int[] array = GetArrayMock(name);
            int actual = Homeworks.ArraysOne.FindMaxValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("easyArray1", 9)]
        [TestCase("easyArray2", 8)]
        [TestCase("easyArray3", 3)]
        [TestCase("easyArray4", 6)]
        [TestCase("easyArray5", 4)]
        public void FindIndexOfMinValue(string name, int expected)
        {
            int[] array = GetArrayMock(name);
            int actual = Homeworks.ArraysOne.FindIndexOfMinValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("easyArray1", 8)]
        [TestCase("easyArray2", 5)]
        [TestCase("easyArray3", 10)]
        [TestCase("easyArray4", 4)]
        [TestCase("easyArray5", 1)]
        public void FindIndexOfMaxValue(string name, int expected)
        {
            int[] array = GetArrayMock(name);
            int actual = Homeworks.ArraysOne.FindIndexOfMaxValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("easyArray1", -11)]
        [TestCase("easyArray2", 1734)]
        [TestCase("easyArray3", -9613)]
        [TestCase("easyArray4", 191)]
        [TestCase("easyArray5", -214)]
        public void CountSumOfOddIndex(string name, int expected)
        {
            int[] array = GetArrayMock(name);
            int actual = Homeworks.ArraysOne.CountSumOfOddIndex(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("easyArray1", "easyArray1Reverse")]
        [TestCase("easyArray2", "easyArray2Reverse")]
        [TestCase("easyArray3", "easyArray3Reverse")]
        [TestCase("easyArray4", "easyArray4Reverse")]
        [TestCase("easyArray5", "easyArray5Reverse")]
        public void ReverseArray(string name, string expectedName) 
        {
            int[] array = GetArrayMock(name);
            int[] actual = Homeworks.ArraysOne.ReverseArray(array);
            int[] expected = GetExpectedMock(expectedName);
            Assert.AreEqual(actual, expected);
        }

        [TestCase("easyArray1", 6)]
        [TestCase("easyArray2", 5)]
        [TestCase("easyArray3", 4)]
        [TestCase("easyArray4", 6)]
        [TestCase("easyArray5", 5)]
        public void CountSumOfOddNumbers(string name, int expected)
        {
            int actual = Homeworks.ArraysOne.CountSumOfOddNumbers(GetArrayMock(name));
            Assert.AreEqual(expected, actual);
        }

        [TestCase("easyArray1", "easyArray1ReverseHalf")]
        [TestCase("easyArray2", "easyArray2ReverseHalf")]
        [TestCase("easyArray3", "easyArray3ReverseHalf")]
        [TestCase("easyArray4", "easyArray4ReverseHalf")]
        [TestCase("easyArray5", "easyArray5ReverseHalf")]
        public void ChangeHalvesOfArray(string name, string expectedName)
        {
            int[] array = GetArrayMock(name);
            int[] actual = Homeworks.ArraysOne.ChangeHalvesOfArray(array);
            int[] expected = GetExpectedMock(expectedName);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("easyArray1", "easyArray1Up")]
        [TestCase("easyArray2", "easyArray2Up")]
        [TestCase("easyArray3", "easyArray3Up")]
        [TestCase("easyArray4", "easyArray4Up")]
        [TestCase("easyArray5", "easyArray5Up")]
        public void SortArrayByBubble(string name, string expectedName)
        {
            int[] array = GetArrayMock(name);
            int[] actual = Homeworks.ArraysOne.SortArrayByBubble(array);
            int[] expected = GetExpectedMock(expectedName);
            Assert.AreEqual(expected, actual);
        }


        [TestCase("easyArray1", "easyArray1Down")]
        [TestCase("easyArray2", "easyArray2Down")]
        [TestCase("easyArray3", "easyArray3Down")]
        [TestCase("easyArray4", "easyArray4Down")]
        [TestCase("easyArray5", "easyArray5Down")]
        public void SortArrayBySelect(string name, string expectedName)
        {
            int[] array = GetArrayMock(name);
            int[] actual = Homeworks.ArraysOne.SortArrayBySelect(array);
            int[] expected = GetExpectedMock(expectedName);
            Assert.AreEqual(expected, actual);
        }

        public static int[] GetArrayMock(string name)
        {
            switch (name) {
                case "easyArray1":
                    return new int[] { 5, 7, -8, 0, -17, 1, 1, 69, 100, -88 };
                case "easyArray2":
                    return new int[] { 8, 8, 0, 526, 9, 1251, -89, -51, -4741};
                case "easyArray3":
                    return new int[] { -74, 25, -88, -9734, -894, -6, 0, 54, 97, 48, 777, 0, 3};
                case "easyArray4":
                    return new int[] { 79, 46, 46, 54, 92, 7,5, 41, 75, 43, 28 };
                case "easyArray5":
                    return new int[] { -23, -8, -9, -8, -95, -72, -39, -88, -23, -38 };
                case "randomArray":
                    Random r = new Random();
                    int len = r.Next(20);
                    int[] array = new int[len];
                    for (int i=0; i < len; i++)
                    {
                        array[i] = r.Next(-100, 100);
                    }
                    return array;
                case "equalElementsArray":
                    return new int[] { 5, 5, 5, 5, 5, 5 };
                default:
                    return new int[] { };
                    }
        }

        public static int[] GetExpectedMock(string name)
        {
            switch (name)
            {
                case "easyArray1Reverse":
                    return new int[] { -88, 100, 69, 1, 1, -17, 0, -8, 7, 5 }; 
                case "easyArray2Reverse":
                    return new int[] { -4741, -51, -89, 1251, 9, 526, 0, 8, 8 };
                case "easyArray3Reverse":
                    return new int[] { 3, 0, 777, 48, 97, 54, 0, -6, -894, -9734, -88, 25, -74}; 
                case "easyArray4Reverse":
                    return new int[] { 28, 43, 75, 41, 5, 7, 92, 54, 46, 46, 79 };
                case "easyArray5Reverse":
                    return new int[] { -38, -23, -88, -39, -72, -95, -8, -9, -8, -23 };
                case "easyArray1ReverseHalf":
                    return new int[] { 1, 1, 69, 100, -88, 5, 7, -8, 0, -17 };
                case "easyArray2ReverseHalf":
                    return new int[] { 1251, -89, -51, -4741, 9, 8, 8, 0, 526 };
                case "easyArray3ReverseHalf":
                    return new int[] { 54, 97, 48, 777, 0, 3, 0, -74, 25, -88, -9734, -894, -6 };
                case "easyArray4ReverseHalf":
                    return new int[] { 5, 41, 75, 43, 28, 7, 79, 46, 46, 54, 92 };
                case "easyArray5ReverseHalf":
                    return new int[] {  -72, -39, -88, -23, -38 , -23, -8, -9, -8, -95};
                case "easyArray1Up":
                    return new int[] { -88, -17, -8, 0, 1, 1, 5, 7, 69, 100 }; 
                case "easyArray2Up":
                    return new int[] { -4741, -89, -51, 0, 8, 8 , 9, 526, 1251 }; 
                case "easyArray3Up":
                    return new int[] { -9734, -894, -88, -74, -6, 0, 0, 3, 25, 48, 54, 97, 777 }; 
                case "easyArray4Up":
                    return new int[] { 5, 7, 28, 41, 43, 46, 46, 54, 75, 79, 92 }; 
                case "easyArray5Up":
                    return new int[] { -95, -88, -72, -39, -38, -23, -23, -9, -8, -8 }; 
                case "easyArray1Down":
                    return new int[] { 100, 69, 7, 5, 1, 1, 0, -8, -17, -88 };
                case "easyArray2Down":
                    return new int[] { 1251, 526, 9, 8, 8, 0, -51, -89, -4741 };
                case "easyArray3Down":
                    return new int[] { 777, 97, 54, 48, 25, 3, 0, 0, -6, -74, -88, -894, -9734 };
                case "easyArray4Down":
                    return new int[] { 92, 79, 75, 54, 46, 46, 43, 41, 28, 7, 5 };
                case "easyArray5Down":
                    return new int[] { -8, -8, -9, -23, -23, -38, -39, -72, -88, -95};
                default:
                    return new int[] { };
            }
        }
            }
}
