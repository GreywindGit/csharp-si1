using System;

namespace CreateClass
{
    public class Employee : Person, ICloneable
    {
        public double Salary { get; set; }
        public string Profession { get; set; }
        public Room Room { get; set; }

        public Employee(string name, DateTime birthDate, Genders gender, double salary, string profession) : base(name, birthDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
        }

        /*public object Clone()
        {
            return this.MemberwiseClone();
        }*/

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Date of Birth: {BirthDate.ToShortDateString()}, Gender: {gender}, Salary: {Salary}, " +
                $"Profession: {Profession}, Room No: {Room.Number}";
        }
    }
}
