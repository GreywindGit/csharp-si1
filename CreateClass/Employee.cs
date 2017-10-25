using System;

namespace CreateClass
{
    public class Employee : Person
    {
        public double Salary { get; set; }
        public string Profession { get; set; }
        public Room Room { get; set; }

        public Employee(string name, DateTime birthDate, Genders gender, double salary, string profession) : base(name, birthDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Date of Birth: {BirthDate.ToShortDateString()}, Gender: {gender}, Salary: {Salary}, Profession: {Profession}";
        }
    }
}
