using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Employee
    {
        /// <summary>
        /// Constructor method
        /// </summary>
        public Employee()
        {
            ScheduleList = new List<Schedule>();
        }

        /// <summary>
        /// Employee Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Schedule list for each employee
        /// </summary>
        public List<Schedule> ScheduleList { get; set; }

        /// <summary>
        /// ToString method to visualize employee information
        /// </summary>
        /// <returns>String employee data</returns>
        public override string ToString()
        {
            var data = "";
            foreach(Schedule schedule in ScheduleList)
            {
                data = data + "," + schedule.ToString();
            }
            data = data.Substring(1);
            return Name + "=" + data;
        }

    }
}
