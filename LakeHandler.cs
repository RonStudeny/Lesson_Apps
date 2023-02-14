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
    }
}
