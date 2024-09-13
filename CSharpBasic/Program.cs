
//using CSharpBasic.Loops;
//ForLoop forLoop = new ForLoop();
// forLoop.TriangleDimensionsCalculator();
//forLoop.LastNumbers();
//forLoop.DividerNumbers();

//// For Calculate the Summary and Average of a set of numbers
//WhileLoop whileLoop = new WhileLoop();

////whileLoop.SumAndAverage();

//whileLoop.BatchPieces();

/*
using CSharpBasic.TriangleArea;
TriangleArea triangleArea = new TriangleArea();
triangleArea.TriangleAreaCalculator();
*/

//using CSharpBasic.EmployeeSalary;
//EmployeeSalary employeeSalary = new EmployeeSalary();
//employeeSalary.EmployeeSalaryCalculator();

// Books 

//using CSharpBasic.Exceptions;
//using CSharpBasic.OOP.Exercise_2;


//BookValidator();

//// To manage the error
//void BookValidator()
//{
//    try
//    {
//        Books books = new Books();

//        books.ShowInformation();

//        if (books.IsLong())
//        {
//            Console.WriteLine("The book is long (more than 500 pages).");
//        }
//        else
//        {
//            Console.WriteLine("The book is not long (500 pages or fewer).");
//        }

//        Console.ReadLine();

//    }
//    catch (ExceptionsErrors ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}

//using CSharpBasic.OOP.Exercise_3;

//Student student = new Student();

//Console.Write("Enter the student's name: ");
//student.Name = Console.ReadLine();

//Console.Write("Enter the student's ID: ");
//student.StudentId = int.Parse(Console.ReadLine());

//Console.Write("Enter the student's career: ");
//student.Career = Console.ReadLine();

//student.InputGrades();
//student.ShowInformation();


//using CSharpBasic.OOP.Exercise_1;

//Quadrants quadrants = new Quadrants();

//quadrants.GetValues();
//quadrants.ShowQuadrants();

// PlayRoll System
using CSharpBasic.OOP.PlayRoll;
using System;

public class TestPlayRollSystem
{
    public static void Main(string[] args)
    {
        // Instantiating objects
        var salariedEmployee = new SalariedEmployee ("Juana", "Perez", "001-32-9384", 800.00m);
        var employeePerHour = new EmployeePerHour ("Maria", "Lopez", "113-89-7387", 16.75m, 40.0M);
        var commissionedEmployee = new commissionedEmployee("Jorge", "Marte", "453-94-3920", 1000.00m, 0.23m);
        var baseEmployeeAndCommission = new MainEmployeePlusCommission("Luisa", "Martinez", "467-38-3904", 4738.00m, 738473.95m, 3627.00m);


        Console.WriteLine("Employees: \n");

        Console.WriteLine("{0}\n{1}: {2:C}\n", salariedEmployee, "Incomings", salariedEmployee.Incoming());
        Console.WriteLine("{0}\n{1}: {2:C}\n", employeePerHour, "Incomings", employeePerHour.Incoming());
        Console.WriteLine("{0}\n{1}: {2:C}\n", commissionedEmployee, "Incomings", commissionedEmployee.Incoming());
        Console.WriteLine("{0}\n{1}: {2:C}\n", baseEmployeeAndCommission, "Incomings", baseEmployeeAndCommission.Incoming());

        Employee[] employees = new Employee[4];

        employees[0] = salariedEmployee;
        employees[1] = employeePerHour;
        employees[2] = commissionedEmployee;
        employees[3] = baseEmployeeAndCommission;

        Console.WriteLine("Procesed employees: \n");

        foreach (Employee ActualEmployee in employees)
        {
            Console.WriteLine(ActualEmployee);

            if (ActualEmployee is MainEmployeePlusCommission)
            {
                MainEmployeePlusCommission employee = (MainEmployeePlusCommission)ActualEmployee;

                employee.BaseSalary *= 1.10M;
                Console.WriteLine("New base salary increased 10%: {0:C}", employee.BaseSalary);

                Console.WriteLine("Incomings {0:C}\n", ActualEmployee.Incoming());
            }   
        }

        for (int i = 0; i < employees.Length; i++) 
        {
            Console.WriteLine("Employee {0} is a {1}", i, employees[i].GetType());
        }
    }
}

