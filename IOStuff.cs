using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hodina
{
    public class IOStuff
    {
        public string Path { get; set; }

        private string pattern;

        IOStuff(string address)
        {
            Path = address;
        }

        private void ReadFromFile()
        {
            string[] fileRead;

            if (File.Exists(Path))
            {
                fileRead = File.ReadAllLines(Path);
            }
  
        }


    }
}
