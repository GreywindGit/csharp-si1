using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person("John", new DateTime(1997, 10, 12), Person.Genders.Male);
            Console.WriteLine(John.Name);
            Console.WriteLine(John.BirthDate);
            Console.WriteLine(John.Gender);
            Console.WriteLine(John.ToString());
            Console.ReadLine();
        }
    }
}
