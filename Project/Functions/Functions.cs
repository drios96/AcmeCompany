using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project.Functions
{
    public class Functions
    {
        /// <summary>
        /// Method <c>ReadFile</c> read a file in txt format
        /// </summary>
        /// <param name="filePath"> file from directory</param>
        /// <returns>List with data from file</returns>
        public static List<string> ReadFile( string  filePath )
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            return lines;
        }

        /// <summary>
        /// Method <c>CreateEmployees</c> create a employees list with their schedules
        /// </summary>
        /// <param name="lines">List with information from file</param>
        /// <returns>List with employee objects with their schedules</returns>
        public static List<Employee> CreateEmployees(List<string> lines)
        {
            if (lines.Any())
            {
                List<Employee> newList = new List<Employee>();
                foreach (string data in lines)
                {
                    var line = data.Trim().Replace(" ", "").Split('=');
                    var nameEmployee = line[0];
                    var schedules = line[1].Split(',');
                    Employee employee = new Employee();
                    employee.Name = nameEmployee;
                    foreach (string sch in schedules)
                    {
                        var day = sch.Substring(0, 2);
                        var hours = sch.Substring(2).Split('-');
                        Schedule schedule = new Schedule();
                        schedule.Day = day;
                        schedule.HourInit = hours[0];
                        schedule.HourEnd = hours[1];
                        employee.ScheduleList.Add(schedule);
                    }
                    newList.Add(employee);
                }
                return newList;
            }
            return null;
        }

        /// <summary>
        /// Method <c>FindMatch</c> Find the possible matches for each employee
        /// </summary>
        /// <param name="employeList">List with employee objects</param>
        /// <returns>List with matches if it exist</returns>
        public static List<string> FindMatch(List<Employee> employeList)
        {
            if (employeList != null)
            {
                List<string> matchesList = new List<string>();
                for (var i = 0; i < employeList.Count; i++)
                {
                    for (var j = i + 1; j < employeList.Count; j++)
                    {
                        var match = 0;
                        foreach (Schedule sch1 in employeList[i].ScheduleList)
                        {
                            foreach (Schedule sch2 in employeList[j].ScheduleList)
                            {
                                if (sch1.Equals(sch2))
                                {
                                    match += 1;
                                }
                            }
                        }
                        if (match > 0)
                        {
                            var message = employeList[i].Name + "-" + employeList[j].Name + ":" + match;
                            matchesList.Add(message);
                        }
                    }
                }
                return matchesList.Any() ? matchesList : new List<string>();
            }         
            return null;
        }

        /// <summary>
        /// Method <c>ExistFile</c> check if a file exists
        /// </summary>
        /// <param name="nameFile"> string with file name</param>
        /// <returns> if the file exists, return the file path; otherwise return null</returns>
        public static string ExistFile(string nameFile)
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var filePath = Path.Combine(projectFolder, nameFile);
            return File.Exists(filePath) ? filePath : null;
        }
    }
}
