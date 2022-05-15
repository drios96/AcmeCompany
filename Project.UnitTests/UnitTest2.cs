using System;
using NUnit.Framework;
using Project.Models;

namespace Project.UnitTests
{
    [TestFixture]
    public class EmployeeTests
    {
        /// <summary>
        /// Method to test if an object is an Employee object
        /// </summary>
        [Test]
        public void Instance_Employee_ReturnsTrue()
        {
            Employee employee = new Employee();
            employee.Name = "Test employee";
            Schedule schedule = new Schedule();
            schedule.Day = "SU";
            schedule.HourInit = "10:00";
            schedule.HourEnd = "14:00";
            employee.ScheduleList.Add(schedule);

            Assert.IsInstanceOf(typeof(Employee), employee);
        }

        /// <summary>
        /// Method to test if an object is not an Employee object
        /// </summary>
        [Test]
        public void Instance_Employee_ReturnsFalse()
        {
            var employee = "Danny Rios";

            Assert.IsNotInstanceOf(typeof(Employee), employee, "This value is not an employee object");
        }
    }
}
