using System;

namespace Hodina
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Jan", "Novak", 3);
        }
    }

    public class Human
    {
        
        public Human(string inpName,string inpSurname) 
        {
            Name = inpName;
            Surname = inpSurname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Student : Human
    {
        int grade;

        public Student(string inpName, string inpSurname ,int inpGrade) : base(inpName, inpSurname)
        {
            grade = inpGrade;
        }

       public int Grade
        {
            get { return this.grade; }
            set { if (value > 0 && value < 6) { this.grade = value; } }
        }

    }

    public class Worker : Human
    {

        public Worker(string inpName, string inpSurname, decimal inpWage, int inpHours) :base(inpName, inpSurname)
        {
            Wage = inpWage;
            HoursWorkedFor = inpHours;
        }

        public decimal Wage { get; set; }
        public int HoursWorkedFor { get; set; }

        public decimal HourlyWage()
        {
            return (decimal)(Wage / HoursWorkedFor);
        }
    }
}
