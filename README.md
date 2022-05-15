# AcmeCompany
Exercise

    Goal
        The goal for the present project is to obtain a list with schedules matches from all your employees.

    Executable
      DIR: Project/bin/Debug/Project.exe
  
    Version
      Net Framework 4.6.1
      NUnit 3.13.3
      NUnit3TestAdapter 4.2.1
 
     You will find the MSTest for unit test bt I don't use it.

    I tried to modularize the project and in this case this contains the following structure:
      Project
      |-Packages
      |-Project
        | Models
        | Functions
        | Documents
        | Programs.cs
      |-Project.UnitTest
        | UnitTest1.cs
        | UnitTest2.cs
        | UnitTest3.cs

    Explanation
      Development
        Important!
          To make this project I assumed the file must be in the project folder and you just know what the matches are.
          I used lists for the solution since when saving the information in objects the easiest way to compare them from my perspective was this data structure.
        Models Folder
          The model folder contain all models for the project.
            Employee
            Schedule
          Each class is used to facilite data manipulation from file and can acces to this information.
        Function Folder
          This folder contains 4 functions that help to resolve this excercise
            ExistFile
              This function is used to check if exist a file to read data.
              Return true if exist flie, otherwise return false.
            ReadFile
              This function is used to read each line form file an return a string list with this information.
            CreateEmployees
              This function process the string list from readFile method and generate a employee list.
              In this function I initialized employee objects and schedule objects to assigned.
              If the string list from ReadFile is empty, this functions not execute and return a null object.
              The facilite to use objects is thath you can acces for any propertie and is more easy to work and compare with anothers objects.
            FindMatch
              This function recieve an employee list to procees it and fin if exists any match possible.
              To find the match I use a Equals method from Schedule class because We need to know what is the exactly schedule that an employee have with other.
              If exists any match, the function return this result in a list of string type, otherwise, the function return a empty list of string type.
      Unit test
        For the tests I use NUnit for practicality, I do 14 test for the following class
          Employee -> 2 tests
          Schedule -> 4 tests
          Functions -> 8 tests
    
        In each tests I considered to prove each method can return a correct object or empty data or not empty data.
        In addition to testing this I also considered whether the instances of the objects sent to the methods would be correct.

        You can find this tests in the Project.UnitTest project in the same solution.
        Each test is documented just like the object classes.
 
     Considerations   
      You can run the project using Rider or Visual Studio.
      Press F5 to run the solution or CTRL + F5 
  
