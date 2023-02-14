using System;
using System.Collections.Generic;
using System.Text;

namespace Hodina
{
    public class Workflow
    {
        public static double Algorithm(double x, double n)
        {
            double res = 1;
            double temp = 1;

            for (int i = 1; i <= n; i++)
            {
                temp = temp * x / i;
                res += i % 2 == 0 ? -temp : temp ;
            }
            return res;
        
        }

        public static int[,] Matice(int n)
        {
            int[,] res = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                res[0, i] = i + 1;
                res[i, 0] = i + 1;
            }

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    res[x, y] = res[0, y] * res[x, 0];
                }
            }

            return res;
        }

        public static void Debug(int[,] arg)
        {
            for (int i = 0; i < arg.GetLength(0); i++)
            {
                for (int j = 0; j < arg.GetLength(1); j++)
                {
                    Console.Write($" {arg[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        //1.

        public static bool IsEven(int x) => x % 2 == 0;

        public static int StringToInt(string arg)
        {
            if (int.TryParse(arg, out int result)) return result;
            else return int.MinValue;
        }

        public static void SwapVals(ref string s, ref string t)
        {
            string tempS = s;
            s = t;
            t = tempS;

        }

            


    }
}
