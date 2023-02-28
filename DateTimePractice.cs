using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace Hodina
{
    public class DateTimePractice
    { 
        public static void SolveShit()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            DateTime janHus = new DateTime(1415, 7, 6);
            DateTime cycler = DateTime.Now;
            int buffer = 0;


            while(buffer < 5)
            {           
                if (cycler.DayOfWeek == janHus.DayOfWeek)
                {
                    buffer++;
                    Console.WriteLine(cycler.Year);
                }
                cycler = cycler.AddYears(1);
            }

            stopwatch.Stop();
            Console.WriteLine($"elapsed: {stopwatch.ElapsedMilliseconds}");
            
        }

        public static void SolveMoreShit()
        {
            List<Person> people = GetPeople(@"people.txt");
            people.Sort();

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }


        }

        private static List<Person> GetPeople(string path, char sep = ' ')
        {
            List<Person> res = new List<Person>();

            string[] read = File.ReadAllLines(path);

            for (int i = 0; i < read.Length; i++)
            {
                string[] split = read[i].Split(sep);
                Person p = new Person()
                {
                    Name = split[0],
                    Surname = split[1],
                    DOB = DateTime.Parse(split[2])
                };
                res.Add(p);
            }
            return res;
        }
    }

    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set;}

        public int CompareTo(Person other)
        {
            return this.DOB.CompareTo(other.DOB);
        }

        public override string ToString() => $"{Surname} - {DateTime.Today.Year - DOB.Year}";
    }
}
