using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class ArraysTwo
    {
        public static int FindMinValue(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        public static int FindMaxValue(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        public static int[] FindIndexOfMinValue(int[,] array)
        {
            int min = array[0, 0];
            int minI = 0;
            int minJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minI = i;
                        minJ = j;
                    }
                }
            }
            return new int[] {minI, minJ};
        }

        public static int[] FindIndexOfMaxValue(int[,] array)
        {
            int max = array[0, 0];
            int indI = 0;
            int indJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        indI = i;
                        indJ = j;
                    }
                }
            }
            return new[] { indI, indJ };
        }

        public static int CountBigBossElements(int[,] array)
        {
            int res = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    bool left = (j != 0 && array[i, j] > array[i, j - 1]) || j == 0;
                    bool right = (j != array.GetLength(1) - 1 && array[i, j] > array[i, j + 1]) || j == array.GetLength(1) - 1;
                    bool up = (i != 0 && array[i, j] > array[i - 1, j]) || i == 0;
                    bool down = (i != array.GetLength(0) - 1 && array[i, j] > array[i + 1, j]) || i == array.GetLength(0) - 1;
                    if (left && right && down && up)
                    {
                        res++;
                    }
                }
            }
            return res;
        }

        public static int[,] TransMass(int[,] array)
        {
            int[,] brray = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            { 
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    brray[j, i] = array[i, j];
                }
            }
            return brray;
        }
    }
}
