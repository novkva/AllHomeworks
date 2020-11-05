using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class Conditions
    {
        public static int CheckAndCountTwoVariables(int a, int b)
        {
            if (a > b)
            {
                return a + b;
            }
            if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }

        public static string FindQuarter(int x, int y)
        {
            if (x > 0 && y > 0)
            { 
                return "I"; 
            }
            if (x < 0 && y > 0)
            {
                return "II";
            }
            if (x < 0 && y < 0)
            {
                return "III";
            }
            if (x > 0 && y < 0)
            {
                return "IV";
            }
            throw new Exception("x or y can't be zero");
        }

        public static int[] SortToUp(int a, int b, int c)
        {
            if (a <= b && a <= c)
            {
                if (b <= c)
                {
                    return new[] { a, b, c };
                }
                else
                {
                    return new[]{a, c, b};

                }
            }
            else if (b <= a && b <= c)
            {
                if (a <= c)
                {
                    return new[] {b, a, c};
                }
                else
                {
                    return new[] { b, c, a };
                }
            }
            else if (a <= b)
            {
                return new[] { c, a, b };
            }
            else
            {
                return new[] { c, b, a }; ;
            }
        }

        static int FindDiscriminant (int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }

        public static double[] SolveQuadroEquation(int a, int b, int c)
        {
            double x1, x2;
            int discriminant = FindDiscriminant(a, b, c);
            if (discriminant > 0)
            {
                x1 = (-1 * b + Math.Sqrt(discriminant)) / 2 / a;
                x2 = (-1 * b - Math.Sqrt(discriminant)) / 2 / a;
                return new double[] { Math.Round(x1, 2), Math.Round(x2, 2) };
            }
            if (discriminant == 0)
            {
                x1 = (double)-1 * b / 2 / a;
                //x1 = Math.Round(x1, 2);
                return new double[] { Math.Round(x1, 2) };
            }
            return new double[] { };
        }

        public static string WriteNumber(int number)
        {
            string result = "";
            if (number / 10 == 1)
            {
                switch (number)
                {
                    case 10:
                        result +="Десять";
                        break;
                    case 11:
                        result += "Одиннадцать";
                        break;
                    case 12:
                        result += "Двенадцать";
                        break;
                    case 13:
                        result += "Тринадцать";
                        break;
                    case 14:
                        result +="Четырнадцать";
                        break;
                    case 15:
                        result +="Пятнадцать";
                        break;
                    case 16:
                        result +="Шестнадцать";
                        break;
                    case 17:
                        result +="Семнадцать";
                        break;
                    case 18:
                        result +="Восемнадцать";
                        break;
                    case 19:
                        result +="Девятнадцать";
                        break;
                }
            }
            else
            {
                switch (number / 10)
                {
                    case 2:
                        result +="Двадцать";
                        break;
                    case 3:
                        result +="Тридцать";
                        break;
                    case 4:
                        result +="Сорок";
                        break;
                    case 5:
                        result +="Пятьдесят";
                        break;
                    case 6:
                        result +="Шестьдесят";
                        break;
                    case 7:
                        result +="Семьдесят";
                        break;
                    case 8:
                        result +="Восемьдесят";
                        break;
                    case 9:
                        result +="Девяносто";
                        break;
                }
                switch (number % 10)
                {
                    case 1:
                        result +=" один";
                        break;
                    case 2:
                        result +=" два";
                        break;
                    case 3:
                        result +=" три";
                        break;
                    case 4:
                        result +=" четыре";
                        break;
                    case 5:
                        result +=" пять";
                        break;
                    case 6:
                        result +=" шесть";
                        break;
                    case 7:
                        result +=" семь";
                        break;
                    case 8:
                        result +=" восемь";
                        break;
                    case 9:
                        result +=" девять";
                        break;
                }
            }
            return result;
        }
    }
}
