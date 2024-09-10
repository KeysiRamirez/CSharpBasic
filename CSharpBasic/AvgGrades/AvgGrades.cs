using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.AvgGrades
{
    /// <summary>
    /// Clase para leer tres calificaciones y calcular
    /// el promedio. Si el promedio es igual o superior a siete, 
    /// imprimir un mensaje indicando que el alumno ha aprobado.
    /// </summary>
    public class AvgGrades
    {
        public void AvgGradesCalculator()
        {
            // Declaring the variables
            int sum_grades = 0, average_grade = 0;
            string input = string.Empty;

            // Request for the 3 grades
            for (int i = 1; i <= 3; i++)
            {
                // To get the grades
                Console.Write("Enter the grade: ");
                input = Console.ReadLine();

                // Validate if the string is null
                if (string.IsNullOrEmpty(input))
                {
                    Console.Write($" Invalid input entered: {input}, you must enter a number");
                    return;
                }
                // To validate if the number is not 0

                else if (!int.TryParse(input, out sum_grades))
                {
                    Console.WriteLine($"The entered number is invalid {input}");
                    return;
                }

                else
                {
                    // To convert the input values to an integer in order to get the average
                    sum_grades += Convert.ToInt32(input);
                    average_grade = sum_grades / 3;
                }
            }

            // Calculate the average for the input grades


            // Defining the condition according the average
            string result = average_grade >= 7 ? $"Studient passed with: {average_grade}" : $"Studient failed with: {average_grade}";

            // Output the condition
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
