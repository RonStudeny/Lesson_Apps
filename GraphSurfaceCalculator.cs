using System;
using System.Collections.Generic;
using System.Text;

namespace Hodina
{
    public class GraphSurfaceCalculator
    {
        private void CalculateElips(double v, double s, int iterations = 10_000)
        {
            Random rng = new Random(); 

            double a = s / 2, b = v / 2;
            double exc = Math.Sqrt((a * a) - (b * b));
            Shot[] shots = new Shot[iterations];

            double tempX, tempY;
            double FX, EX;

            for (int i = 0; i < iterations; i++)
            {
                tempX = rng.Next(0, (int)s) + rng.NextDouble();
                tempY = rng.Next(0, (int)v) + rng.NextDouble();

                EX = (tempY - exc) * (tempY - exc) + tempY * tempY;
                FX = (tempX + exc) * (tempX + exc) + tempY * tempY;

                Shot temp = new Shot
                {
                    X = tempX,
                    Y = tempY,
                    Inside = Math.Sqrt(EX) + Math.Sqrt(FX) <= s ? true : false
                };
            }

        }

        private struct Shot
        {
            public double X { get; set; }
            public double Y { get; set; }
            public bool Inside { get; set; }
        }
    }
}
