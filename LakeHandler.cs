using System;
using System.Collections.Generic;
using System.Text;

namespace Hodina
{
    public class LakeHandler
    {
        public int[,] Lake { get; set; } = new int[100,100];
        Random rng = new Random();

        public LakeHandler(int fishCount)
        {
            PutFishIn(fishCount);
        }

        private void PutFishIn(int maxFish)
        {
            int maxX, maxY;
            maxX = Lake.GetLength(0);
            maxY = Lake.GetLength(1);

            for (int i = 0; i < maxFish + 1; i++)
            {
                Lake[rng.Next(maxX), rng.Next(maxY)]++;
            }
        }

        public List<Catch> GetCatches(int netOffset = 2)
        {
            List<Catch> res = new List<Catch>();

            Catch thisCatch = new Catch();

            for (int x = 0; x < Lake.GetLength(0); x++)
            {
                for (int y = 0; y < Lake.GetLength(1); y++)
                {
                    if (Lake.GetLength(0) > x + netOffset || Lake.GetLength(1) > y + netOffset)
                    {
                        thisCatch.x = x;
                        thisCatch.y = y;
                        thisCatch.haul = CalculateCatch(x, y, 3);
                        res.Add(thisCatch);    
                    }
                }
            }
            res.Sort();
            return res;
        }

        private int CalculateCatch(int xPos, int yPos, int netSize)
        {
            int res = 0;
            for (int x = xPos; x <= netSize; x++)
            {
                for (int y = yPos; y <= netSize; y++)
                {
                    res += Lake[x, y];
                }
            }

            return res;
        }

        public void Debug(int[,] args)
        {
            for (int x = 0; x < args.GetLength(0); x++)
            {
                for (int y = 0; y < args.GetLength(1); y++)
                {
                    Console.Write($"{args[y, x]} ");
                }
                Console.WriteLine();
            }
        }

        public struct Catch
        {
            public int x, y, haul;
            public override string ToString()
            {
                return $"{haul} {x} {y}"; 
            }
        }
    }
}
