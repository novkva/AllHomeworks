using System;
using NUnit.Framework;

namespace Homeworks.Tests
{
    class ArraysTwo
    {
        [TestCase("simpleArray1", -23)]
        [TestCase("simpleArray2", -99)]
        [TestCase("simpleArray3", -98)]
        [TestCase("simpleArray4", -34)]
        [TestCase("simpleArray5", -49)]
        public void FindMinValue(string name, int expected)
        {
            int[,] array = GetArrayMock(name);
            int actual = Homeworks.ArraysTwo.FindMinValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("simpleArray1", 78)]
        [TestCase("simpleArray2", 78)]
        [TestCase("simpleArray3", 105)]
        [TestCase("simpleArray4", 69)]
        [TestCase("simpleArray5", 111)]
        public void FindMaxValue(string name, int expected)
        {
            int[,] array = GetArrayMock(name);
            int actual = Homeworks.ArraysTwo.FindMaxValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("simpleArray1", new int[] { 3, 0 })]
        [TestCase("simpleArray2", new int[] { 1, 3 })]
        [TestCase("simpleArray3", new int[] { 1, 2 })]
        [TestCase("simpleArray4", new int[] { 1, 1 })]
        [TestCase("simpleArray5", new int[] { 2, 0 })]
        public void FindIndexOfMinValue(string name, int[] expected)
        {
            int[,] array = GetArrayMock(name);
            int[] actual = Homeworks.ArraysTwo.FindIndexOfMinValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("simpleArray1", new int[] { 0, 1 })]
        [TestCase("simpleArray2", new int[] { 0, 0 })]
        [TestCase("simpleArray3", new int[] { 4, 3 })]
        [TestCase("simpleArray4", new int[] { 2, 1 })]
        [TestCase("simpleArray5", new int[] { 3, 1 })]
        public void FindIndexOfMaxValue(string name, int[] expected)
        {
            int[,] array = GetArrayMock(name);
            int[] actual = Homeworks.ArraysTwo.FindIndexOfMaxValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("simpleArray1", 3)]
        [TestCase("simpleArray2", 4)]
        [TestCase("simpleArray3", 7)]
        [TestCase("simpleArray4", 3)]
        [TestCase("simpleArray5", 4)]
        public void CountBigBossElements(string name, int expected)
        {
            int actual = Homeworks.ArraysTwo.CountBigBossElements(GetArrayMock(name));
            Assert.AreEqual(expected, actual);
        }

        [TestCase("simpleArray1", "simpleArray1Trans")]
        [TestCase("simpleArray2", "simpleArray2Trans")]
        [TestCase("simpleArray3", "simpleArray3Trans")]
        [TestCase("simpleArray4", "simpleArray4Trans")]
        [TestCase("simpleArray5", "simpleArray5Trans")]
        public void TransMass(string name, string expectedName) 
        {
            int[,] expected = GetExpectedMock(expectedName);
            int[,] actual = Homeworks.ArraysTwo.TransMass(GetArrayMock(name));
            Assert.AreEqual(expected, actual);
        }

        public static int[,] GetArrayMock(string name)
        {
            switch (name)
            {
                case "simpleArray1":
                    return new int[,] { 
                        {8, 78, -9 },
                        {77, 51, 3 },
                        {-1, 0, 74 },
                        {-23, 22, 22 }
                    };
                case "simpleArray2":
                    return new int[,] {
                        {78, 1, 0, -5},
                        {32, 51, -9, -99},
                        {-8, 41, 0, 25},
                        {66, 55, 44, -11}
                    };
                case "simpleArray3":
                    return new int[,] {
                        {0, 5, 8, 74, 49 },
                        {14, -5, -98, -35, 56},
                        {18, 0, 54, 64, -5 },
                        {-89, 84, 22, 44, 41 },
                        { 41, -87, -5, 105, -88}
                    };
                case "simpleArray4":
                    return new int[,] {
                        {5, 9, 11 },
                        {41, -34, -5 },
                        {0, 69, 51 },
                    };
                case "simpleArray5":
                    return new int[,] {
                        {1, 9},
                        {87, -6},
                        {-49, -28},
                        {-44, 111 },
                        { 36, 0}
                    };
                default:
                    return new int[,] { };
            }
        }

        public static int[,] GetExpectedMock(string name)
        {
            switch (name)
            {
                case "simpleArray1Trans":
                    return new int[,] {
                        {8, 77, -1, -23},
                        {78, 51, 0, 22},
                        {-9, 3, 74, 22}
                    };
                case "simpleArray2Trans":
                    return new int[,] {
                        {78, 32, -8, 66},
                        {1, 51, 41, 55},
                        {0, -9, 0, 44},
                        {-5, -99, 25, -11}
                    };
                case "simpleArray3Trans":
                    return new int[,] {
                        {0, 14, 18, -89, 41},
                        {5, -5, 0, 84, -87},
                        {8, -98, 54, 22, -5 },
                        {74, -35, 64, 44, 105},
                        {49, 56, -5, 41, -88 }
                    };
                case "simpleArray4Trans":
                    return new int[,] {
                        {5, 41, 0},
                        {9, -34, 69},
                        {11, -5, 51 }
                    };
                case "simpleArray5Trans":
                    return new int[,] {
                        {1, 87, -49, -44, 36},
                        {9, -6, -28, 111, 0}
                    };
                default:
                    return new int[,] { };
            }
        }
    }
}
