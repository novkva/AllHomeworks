using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class ArraysOne
    {
        public static int FindMinValue(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int FindMaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int FindIndexOfMinValue(int[] array)
        {
            int minInd = 0;
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    minInd = i;
                    min = array[i];
                }
            }
            return minInd;
        }

        public static int FindIndexOfMaxValue(int[] array)
        {
            int maxInd = 0;
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    maxInd = i;
                    max = array[i];
                }
            }
            return maxInd;
        }

        public static int CountSumOfOddIndex(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return sum;
        }

        public static int[] ReverseArray (int[] array)
        {

            for (int i = 0; i < array.Length / 2; i++)
            {
                int j = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = array[i];
                array[i] = j;
            }
            return array;
        }

        public static int CountSumOfOddNumbers (int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum++;
                }
            }
            return sum;
        }

        public static int[] ChangeHalvesOfArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int j = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = array[array.Length / 2 - i - 1];
                array[array.Length / 2 - i - 1] = j;
            }
            return array;
        }

        public static int[] SortArrayByBubble(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int k;
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        k = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = k;
                    }
                }
            }
            return array;
        }

        public static int[] SortArrayBySelect(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int max = array[i];
                int indMax = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] > max)
                    {
                        max = array[j];
                        indMax = j;
                    }
                }
                int k = array[i];
                array[i] = max;
                array[indMax] = k;
            }
            return array;
        }
    }
}
