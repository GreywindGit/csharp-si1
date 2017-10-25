using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Jane = new Employee("Jane", new DateTime(1991, 5, 17), Person.Genders.Female, 2000, "astronaut");
            Jane.Room = new Room(115);
            Console.WriteLine(Jane.ToString());
            Console.WriteLine($"Jane's room number is {Jane.Room.Number}");
            Person Jill = new Employee("Jill", new DateTime(1972,8,7), Person.Genders.Female, 1500, "personal assistant");
            Jill.Name = "Jill McPherson";
            Console.WriteLine(Jill.ToString());
            //Console.ReadLine();
        }
    }
}
