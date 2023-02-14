using System;
using System.Collections.Generic;
using System.Text;

namespace Hodina
{
    public class RandomNums
    {
        public static int[] GetNums(int N)
        {
            HashSet<int> nums = new HashSet<int>();
            Random rng = new Random();
            int[] res = new int[N];

            while (nums.Count < N)
            {
                nums.Add(rng.Next(-N, N + 1));
            }

            nums.CopyTo(res);
            return res;
        }
       
        public static void Debug(int[] args)
        {
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine(args[i]);
        }
    }
}
