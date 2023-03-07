using System;
using System.Collections.Generic;

namespace Hodina
{
    class Program
    {

        static void Main(string[] args)
        {
            //LakeHandler lake = new LakeHandler(100_000);
            ////lake.Debug(lake.Lake);
            //List<LakeHandler.Catch> list = lake.GetCatches();

            StringRehersal.DebugTheArr(StringRehersal.GetSums());
        }


        public struct TestStruct
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"Name: {Name} Age: {Age}"; 
            }
        }

    }
}
