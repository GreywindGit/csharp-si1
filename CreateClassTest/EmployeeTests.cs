using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateClass;

namespace CreateClassTests
{
    [TestClass]
    public class EmployeeTests
    {
        Employee Adam;

        [TestInitialize]
        public void TestInitialize()
        {
            Adam = new Employee("Adam", new DateTime(1990, 5, 6), Person.Genders.Male, 2000, "QA");
        }

        [TestMethod]
        public void TestEmployeeInitializationIsValid()
        {
            Assert.AreEqual("Adam", Adam.Name);
            Assert.AreEqual(new DateTime(1990, 5, 6), Adam.BirthDate);
            Assert.AreEqual(Person.Genders.Male, Adam.Gender);
            Assert.AreEqual(2000, Adam.Salary);
            Assert.AreEqual("QA", Adam.Profession);
        }

        [TestMethod]
        public void TestEmployeeUpdateName()
        {
            Adam.Name = "Adam Jenssen";

            var expected = "Adam Jenssen";
            var actual = Adam.Name;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEmployeeUpdateBirthDate()
        {
            Adam.BirthDate = new DateTime(1989, 5, 6);

            var expected = new DateTime(1989, 5, 6);
            var actual = Adam.BirthDate;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEmployeeUpdateSalary()
        {
            Adam.Salary = 4000;

            var expected = 4000;
            var actual = Adam.Salary;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEmployeeUpdateProfession()
        {
            Adam.Profession = "actor";

            var expected = "actor";
            var actual = Adam.Profession;

            Assert.AreEqual(expected, actual);
        }
    }
}
