using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class Cycles
    {
        public static int AToPowerB(int a, int b)
        {
            if (b < 0)
            {
                throw new Exception("power musr be more or equal zero");
            }
            int res = 1;

            if (a == 0 && b != 0)
            {
                return 0;
            }
            for (int i = 0; i < b; i++)
            {
                res *= a;
            }
            return res;
        }

        public static int[] ShowDevidendFromA(int a)
        {
            if (a == 0)
            {
                throw new Exception("number can't be zero");
            }
            a = Math.Abs(a);
            int numberOfDevidends = 0;
            for (int i = 0; i <= 1000; i += a)
            {
                numberOfDevidends++;
            }
            int[] devidends = new int[numberOfDevidends];
            for (int i = 0; i < numberOfDevidends; i++)
            {
                devidends[i] = a * i;
            }
            return devidends;
        }

        public static int FindAmountNumbers (int a)
        {
            int amount = 1;
            while (amount * amount < a)
            {
                amount++;
            }
            return (amount - 1);
        }

        public static int FindBiggestDevider(int a)
        {
            a = Math.Abs(a);
            if (a == 1)
            {
                return 1;
            }
            int k = a / 2;
            while (true)
            {
                if (a % k == 0)
                {
                    return k;
                }
                k--;
            }
        }

        public static int FindSummOfNumbersDevidedBySeven(int a, int b)
        {
            int result = 0;
            if (b < a)
            {
                int i = a;
                a = b;
                b = i;
            }
            while (a % 7 != 0)
            {
                a++;
            }
            for (int i = a; i <= b; i += 7)
            {
                result += i;
            }
            return result;

        }

        public static int FindFibonacci (int n)
        {
            int res = 0;
            int number2 = 1;
            for (int i = 0; i < n; i++)
            {
                int number1 = res;
                res += number2;
                number2 = number1;
            }
            return res;
        }

        public static int FindBiggestDeviderTwo(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }

        public static int FindWhoseCube(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int x = 0;
            int y = n;
            int k = 0;
            while (x * x * x != n && y * y * y != n)
            {
                k = (x + y) / 2;
                if (k * k * k > n)
                {
                    y = k;
                }
                else
                {
                    x = k;
                }
            }
            return k;
        }

        public static int FindCountOddNumbers(int a)
        {
            int res = 0;
            while (a != 0)
            {
                if ((a % 10) % 2 != 0)
                {
                    res++;
                }
                a /= 10;
            }
            return res;
        }

        public static int FindMirrorNumber(int a)
        {
            int res = 0;
            while (a != 0)
            {
                res = res * 10 + a % 10;
                a /= 10;
            }
            return res;
        }

        public static int ShowAmountNumbersWithStrangeCondition(int n)
        {
            int res = 0;

            for (int i = 1; i <= n; i++)
            {
                int chet = 0;
                int nechet = 0;
                int k = i;
                while (k != 0)
                {
                    if ((k % 10) % 2 == 0)
                    {
                        chet += (k % 10);
                    }
                    else
                    {
                        nechet += (k % 10);
                    }
                    k /= 10;
                }
                if (chet > nechet)
                {
                    res++;
                }

            }
            return res;
        }

        public static bool FindOutSameNumbers(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0) 
            {
                int max = Math.Max(a, b);
                while (max != 0)
                {
                    if (max % 10 == 0)
                    {
                        return true;
                    }
                    max /= 10;
                }
            }

            if (a == b)
            {
                return true;
            }

            while (a != 0) 
            {
                int b1 = b;
                while (b1 != 0)
                {
                    if (b1 % 10 == a % 10)
                    {
                        return true;
                    }
                    b1 /= 10;
                }
                a /= 10;
            }
            return false;
        }
    }
}
