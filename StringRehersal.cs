using System;

namespace Hodina
{
    public class StringRehersal
    {
        public static string[,] GetSums()
        {
            double[,] input = new double[,]
            {
                    { 1.0 , 2.0 , 3.0  },
                    { 5.0 , 4.0 , 2.0 }
            };
            string[,] res = new string[input.GetLength(0) + 1, input.GetLength(1) + 1];
            double bufferX = 0, bufferY = 0;

            for (int i = 0; i < input.GetLength(1); i++) // horizontal
            {
                for (int j = 0; j < input.GetLength(0); j++)
                {
                    bufferX += input[i, j];
                    bufferY += input[j, i];
                }
                res[i, res.GetLength(0)] = bufferX.ToString();
                res[res.GetLength(1), i] = bufferY.ToString();
                bufferX = 0;
                bufferY = 0;
            }

            //for (int i = 0; i < input.GetLength(1); i++) // vertical
            //{
            //    for (int j = 0; j < input.GetLength(0); j++)
            //    {
            //        buffer += input[i, j];
            //    }
            //    res[i, res.GetLength(1)] = buffer.ToString();
            //    buffer = 0;
            //}


            for (int i = 0; i < input.GetLength(0); i++) // rewrite the array
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    res[i, j] = input[i, j].ToString();
                }

            }



            return res;

        }

        public static void DebugTheArr(string[,] args)
        {
            for (int i = 0; i < args.GetLength(0); i++)
            {
                for (int j = 0; j < args.GetLength(1); j++)
                {
                    Console.Write(args[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
