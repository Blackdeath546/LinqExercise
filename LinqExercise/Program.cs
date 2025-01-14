using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sumOfNumbers = numbers.Sum();
            Console.WriteLine(sumOfNumbers);

            //TODO: Print the Average of numbers
            var averageOfNumbers = numbers.Average();
            Console.WriteLine(averageOfNumbers);

            //TODO: Order numbers in ascending order and print to the console
            var ascendingNumbers = numbers.OrderBy(x => x);
            foreach (var number in ascendingNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\n");

            //TODO: Order numbers in descending order and print to the console
            var descendingNumbers = numbers.OrderByDescending(x => x);
            foreach (var number in descendingNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\n");

            //TODO: Print to the console only the numbers greater than 6
            var numbersGreaterThan6 = numbers.Where(x => x >= 6);
            foreach (var number in numbersGreaterThan6)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\n");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var only4AcendingNumbers = numbers.Where(x => x < 4);
            foreach (var number in only4AcendingNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\n");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 26;
            var newdecendingNumbers = numbers.OrderByDescending(x => x);
            //Console.WriteLine("Change the value at index 4 to your age, then print the numbers in descending order");
            foreach (var number in newdecendingNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\n");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var employeesStartingWithCOrS = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName);
            foreach (var employee in employeesStartingWithCOrS)
            {
                Console.WriteLine(employee.FullName);
            }
            
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var employeesOver26 = employees.Where(x => x.Age >= 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var employee in employeesOver26)
            {
                Console.WriteLine($"{employee.FullName} and is {employee.Age}");
                
            }
            Console.WriteLine("\n");

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var YOE = employees.Where(x => x.Age >= 35 && x.YearsOfExperience <= 10);
            foreach (var employee in YOE)
            {
                Console.WriteLine($"{employee.FullName} is {employee.Age} and has {employee.YearsOfExperience} years of experience");
            }
            Console.WriteLine();
            Console.WriteLine(YOE.Sum(y => y.YearsOfExperience) + " total years of experience");
            Console.WriteLine();

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine(YOE.Average(y => y.YearsOfExperience) + " Average years of experience");
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            //Employee newEmployee = new Employee("Jotaro", "Kujo", 25, 20);
            
            employees = employees.Append(new Employee("Jotaro", "Kujo", 25, 20)).ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FullName);
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
