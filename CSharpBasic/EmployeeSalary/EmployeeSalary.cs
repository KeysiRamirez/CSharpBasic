using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.EmployeeSalary
{
    public class EmployeeSalary
    {
        /// <summary>
        /// En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, 
        /// realizar un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 
        /// y cuántos cobran más de $300. Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.
        /// </summary>
        public void EmployeeSalaryCalculator()
        {
            try
            {
                // Defining variables
                int salary = 0, employeesQuantity = 0, amountSpentOnSalary = 0, employeeCounterUnder300 = 0, employeeCounterOver300 = 0;

                // Requesting for the employees quantity
                Console.WriteLine("Calculate how many employes earn more than $300 and how many earn between $100 and $300");

                Console.Write("Enter the employees quantity: ");

                // Validates if the user entered an number
                if (!int.TryParse(Console.ReadLine(), out employeesQuantity)) 
                {
                    Console.WriteLine($"Invalid input entered {employeesQuantity}, you must enter a number!");
                    return;
                }

                if (employeesQuantity < 0)
                {
                    Console.WriteLine($"Invalid input entered {employeesQuantity}, the employee quantity cannot be negative!");
                    return;
                }

                // Requesting for the salaries
                for (int i = 1; i <= employeesQuantity; i++) 
                {
                    Console.Write($"Enter the salary for the employee {i}: ");

                    // Validates if the user entered an number
                    if (!int.TryParse(Console.ReadLine(), out salary))
                    {
                        Console.WriteLine($"Invalid input entered {salary}, you must enter a number!");
                        i--;
                        continue;
                    }

                    if (salary < 0) 
                    {
                        Console.WriteLine($"Invalid input entered {salary}, the salary cannot be negative!");
                        i--;
                        continue;
                    }

                    if (salary < 100 || salary > 500)
                    {
                        Console.WriteLine($"Invalid salary entered: {salary}, the salaries are between $100 and $500");
                        i--;
                        continue;
                    }

                    // Counting how many employees earn under $300
                    if (salary >= 100 && salary <= 300)
                    {
                        employeeCounterUnder300++;
                    }

                    // Counting how many employees earn over $300
                    else
                    {
                        employeeCounterOver300++;
                    }

                    // Calculating the amount the company spend on salaries
                    amountSpentOnSalary += salary;

                }

                //outputing the results
                Console.WriteLine($"Employees who earn under $300: {employeeCounterUnder300} \nEmployees who earn over $300: {employeeCounterOver300}");
                Console.WriteLine($"The amount that the company spend on salary is: {amountSpentOnSalary}");

            } catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
        } 

    }
}
