using System;
using NUnit.Framework;
using Project.Models;
using Project.Functions;
using System.IO;
using System.Collections.Generic;

namespace Project.UnitTests
{
    [TestFixture]
    public class FunctionTests
    {
        /// <summary>
        /// Method to check if the function return a list with any element
        /// </summary>
        [Test]
        public void CreateEmployees_Functions_ReturnList()
        {
            List<string> data = new List<string>();
            data.Add("RENE=MO10:00-12:00,TU10:00-12:00,TH01:00-03:00,SA14:00-18:00,SU20:00- 21:00");
            var result = Functions.Functions.CreateEmployees(data);

            Assert.IsNotEmpty(result);

        }

        /// <summary>
        /// Method to check if the function return an not null object
        /// </summary>
        [Test]
        public void CreateEmployees_Functions_IsNotNull()
        {
            List<string> data = new List<string>();
            data.Add("RENE=MO10:00-12:00,TU10:00-12:00,TH01:00-03:00,SA14:00-18:00,SU20:00- 21:00");
            var result = Functions.Functions.CreateEmployees(data);

            Assert.IsNotNull(result);

        }

        /// <summary>
        /// Method to check if the function return a null object
        /// </summary>
        [Test]
        public void CreateEmployees_Functions_ReturnNull()
        {
            List<string> data = new List<string>();
            var result = Functions.Functions.CreateEmployees(data);

            Assert.IsNull(result);

        }

        /// <summary>
        /// Method to check if the object from function is an employee list instance
        /// </summary>
        [Test]
        public void CreateEmployees_Functions_InstanceEmployeeList()
        {
            List<string> data = new List<string>();
            data.Add("RENE=MO10:00-12:00,TU10:00-12:00,TH01:00-03:00,SA14:00-18:00,SU20:00- 21:00");
            var result = Functions.Functions.CreateEmployees(data);            
            Assert.IsInstanceOf(typeof(List<Employee>),result);

        }

        /// <summary>
        /// Method to check if the object from function is not an employee list instance
        /// </summary>
        [Test]
        public void CreateEmployees_Functions_NotInstanceEmployeeList()
        {
            List<string> data = new List<string>();
            var result = Functions.Functions.CreateEmployees(data);
            Assert.IsNotInstanceOf(typeof(List<Employee>), result);
        }

        /// <summary>
        /// Method to check if the function return a null object
        /// </summary>
        [Test]
        public void FindMatch_Functions_IsNotNull()
        {
            List<Employee> data = new List<Employee>();
            var result = Functions.Functions.FindMatch(data);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Method to check if the function return a empty object
        /// </summary>
        [Test]
        public void FindMatch_Functions_EmptyList()
        {
            List<Employee> data = new List<Employee>();
            var result = Functions.Functions.FindMatch(data);
            Assert.IsEmpty(result);
        }

        /// <summary>
        /// Method to check if the function return any match
        /// </summary>
        [Test]
        public void FindMatch_Functions_NotEmptyList()
        {
            List<Employee> data = new List<Employee>();
            Employee employee = new Employee();
            employee.Name = "Test employee";
            Schedule schedule = new Schedule();
            schedule.Day = "SU";
            schedule.HourInit = "10:00";
            schedule.HourEnd = "14:00";
            employee.ScheduleList.Add(schedule);
            data.Add(employee);
            Employee employee2 = new Employee();
            employee2.Name = "Test employee";
            Schedule schedule2 = new Schedule();
            schedule2.Day = "SU";
            schedule2.HourInit = "10:00";
            schedule2.HourEnd = "14:00";
            employee2.ScheduleList.Add(schedule);
            data.Add(employee2);
            var result = Functions.Functions.FindMatch(data);
            Assert.IsNotEmpty(result);
        }
    }
}
