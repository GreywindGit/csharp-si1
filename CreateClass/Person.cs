using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public enum Genders {Male, Female};
        private Genders gender;

        public Person(string name, DateTime birthDate, Genders gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.gender = gender;
        }

        public Genders Gender { get { return gender; } }

        public override string ToString()
        {
            return "Name: " + Name + ", Date of Birth: " + BirthDate.ToShortDateString() + ", Gender: " + gender.ToString();
        }
    }
}
