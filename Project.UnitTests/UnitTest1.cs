using System;
using NUnit.Framework;
using Project.Models;

namespace Project.UnitTests
{
    [TestFixture]
    public class ScheduleTests
    {
        /// <summary>
        /// Method to test if two schedule objects are same
        /// </summary>
        [Test]
        public void Equals_Schedule_ReturnsTrue()
        {
            var scheduleOne = new Schedule();
            scheduleOne.Day = "MO";
            scheduleOne.HourInit = "10:00";
            scheduleOne.HourEnd = "14:00";
            var scheduleTwo = new Schedule();
            scheduleTwo.Day = "MO";
            scheduleTwo.HourInit = "10:00";
            scheduleTwo.HourEnd = "14:00";

            var result = scheduleOne.Equals(scheduleTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Method to test if two schedule objects are not same
        /// </summary>
        [Test]
        public void Equals_Schedule_ReturnsFalse()
        {
            Schedule scheduleOne = new Schedule();
            scheduleOne.Day = "SU";
            scheduleOne.HourInit = "10:00";
            scheduleOne.HourEnd = "14:00";
            Schedule scheduleTwo = new Schedule();
            scheduleTwo.Day = "MO";
            scheduleTwo.HourInit = "10:00";
            scheduleTwo.HourEnd = "14:00";

            var result = scheduleOne.Equals(scheduleTwo);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Method to test if an object is a Schedule object
        /// </summary>
        [Test]
        public void Instance_Schedule_ReturnsTrue()
        {
            Schedule schedule = new Schedule();
            schedule.Day = "SU";
            schedule.HourInit = "10:00";
            schedule.HourEnd = "14:00";
            Assert.IsInstanceOf(typeof(Schedule), schedule);
        }

        /// <summary>
        /// Method to test if an object is not a Schedule object
        /// </summary>
        [Test]
        public void Instance_Schedule_ReturnsFalse()
        {
            var schedule = "MO10:00-12:00";
            Assert.IsNotInstanceOf(typeof(Schedule), schedule, "This value is not a schedule object");
        }
    }
}
