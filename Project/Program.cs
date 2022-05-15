using System;
using System.Linq;

namespace Project
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            PresentProject();
            var filePath = Functions.Functions.ExistFile(@"Project\Documents\Employees.txt");
            if (filePath != null)
            {
                GenerateMatches(filePath);
            }
            else
            {
                Console.WriteLine("The file not exist");
                Console.WriteLine("Bye");
            }

            Console.ReadKey(true);
        }

        /// <summary>
        /// Presentation method
        /// </summary>
        public static void PresentProject()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*********WELCOME TO ACME COMPANY*********");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");
            
        }
        /// <summary>
        /// Method to do the possible matches
        /// </summary>
        /// <param name="filePath"> file path from file</param>
        public static void GenerateMatches(string filePath)
        {
            Console.WriteLine("This project will read the employee.txt file");
            var lines = Functions.Functions.ReadFile(filePath);
            var employees = Functions.Functions.CreateEmployees(lines);
            var matches = Functions.Functions.FindMatch(employees);
            if (matches != null && matches.Any())
            {
                Console.WriteLine("Showing matches...");
                var stringMatches = string.Join(Environment.NewLine, matches);
                Console.WriteLine(stringMatches);
                Console.WriteLine("Bye");
            } else
            {
                Console.WriteLine("There are not matches\n Bye");
            }
            
        }
    }
}
