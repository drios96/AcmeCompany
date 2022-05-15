using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Schedule
    {
        /// <summary>
        /// Constructor method
        /// </summary>
        public Schedule()
        {

        }
        /// <summary>
        /// Day for schedule
        /// </summary>
        public string Day { get; set; }
        /// <summary>
        /// Initial hour for schedule
        /// </summary>
        public string HourInit { get; set; }

        /// <summary>
        /// End hour for schedule
        /// </summary>
        public string HourEnd { get; set; }

        /// <summary>
        /// ToString method to visualize schedule information
        /// </summary>
        /// <returns>String schedule data</returns>
        public override string ToString()
        {
            return Day + "->" + HourInit + "-" + HourEnd;
        }

        /// <summary>
        /// Equals method to compare two objects
        /// </summary>
        /// <param name="obj"> object to compare</param>
        /// <returns>if object is the same, return true, otherwise, return false</returns>
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Schedule sch = (Schedule)obj;
                return (Day == sch.Day) && (HourInit == sch.HourInit) && (HourEnd == sch.HourEnd);
            }
        }
    }
}
