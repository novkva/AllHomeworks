using System;

namespace Homeworks
{
    public class Variables
    {
        public static double DecideEquation(int a, int b)
        {
            if (a == b)
            {
                throw new Exception("a and b are equals");
            }
            double c = (double)(5 * a + b * b) / (b - a);
            return c;
        }

        public static void ChangeTwoVariables(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }

        public static double DevideAByB (int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("b can't be zero");
            }
            double c = (double)a / b;
            return c;
        }

        public static int FindRamainderOfDivision(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("b can't be zero");
            }
            int c = a % b;
            return c;
        }

        public static double DecideLinearEquation (int a, int b, int c)
        {
            if (a == 0)
            {
                throw new Exception("It's not linear equation");
            }
            double x = (double)(c - b) / a;
            return x;
        }

        public static string DoEquation(int x1, int y1, int x2, int y2) 
        {
            if (x2==x1)
            {
                throw new Exception("x1 can't be equals x2");
            }
            double k = (double)(y2 - y1) / (x2 - x1);
            double b = y1 - k * x1;
            if (k != 0)
            {
                if (b > 0)
                {
                    return $"Y={k:f2}*X+{b:f2}";
                }
                else if (b < 0)
                {
                    return $"Y={k:f2}*X{b:f2}";
                }
                else
                {
                    return $"Y={k:f2}*X";
                }
            }
            else
            {
                return $"Y={b:f2}";
            }
        }
    }
}
