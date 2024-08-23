using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpBasic.Loops
{
    public class ForLoop
    {
        /// <summary>
        /// Class for: 
        /// calcular y contar aquellos cuya área excede un valor límite,
        /// segun un conjunto de datos representando las dimensiones de triángulos.
        /// </summary>
        public void TriangleDimensionsCalculator()
        {
            try
            {
                // Defining Variables
                int triangleBase = 0, limitValue = 0, height = 0, counter = 0, triangleQuantity = 0;
                string triangleBaseEntered = string.Empty, limitValueEntered = string.Empty, heightEntered = string.Empty;
                decimal area = 0;

                // Getting the quantity of triangules to calculate
                Console.Write("Enter the total of triangles to calculate their areas: ");
                triangleQuantity = int.Parse(Console.ReadLine());

                // Requesting for the limit value
                Console.Write("Enter the limit area: ");
                limitValueEntered = Console.ReadLine();

                if (limitValueEntered == null) 
                { 
                    Console.WriteLine("The input cannot be null, you must enter a number!");
                    return;
                }

                if (!int.TryParse(limitValueEntered, out limitValue))
                {
                    Console.WriteLine($"Invalid input entered: {limitValueEntered}");
                    return;
                }

                // Requesting for the triangle dimensions
                for (int i = 1; i <= triangleQuantity; i++) 
                {
                    Console.Write($"Enter the triangle {i} base: ");
                    triangleBaseEntered = Console.ReadLine();

                    // Validate if the triangle base is valid
                    if (triangleBaseEntered == string.Empty || !int.TryParse(triangleBaseEntered, out triangleBase))
                    {
                        Console.WriteLine($"Invalid value entered, you must enter a number!");
                        // allows the user to enter a new number
                        i--;
                        continue;
                    }

                    // Requesting for the triangle height
                    Console.Write($"Enter the triangle {i} height: ");
                    heightEntered = Console.ReadLine();

                    // Validate if the input is valid
                    if (heightEntered == string.Empty || !int.TryParse(heightEntered, out height))
                    {
                        Console.WriteLine($"Invalid value entered, you must enter a number!");
                        // allows the user to enter a new number
                        i--;
                        continue;
                    }

                    area = ((triangleBase * height) / 2);

                    // Compering the area with the value limit entered

                    if (area > limitValue) 
                    {
                        counter++;
                    }

                }

                Console.Write($"The triangles which exceed of the limit value are: {counter}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The was an error during the run, details {ex.Message}");
            }
        }

        /// <summary>
        /// Class for: contar cuántos números, de un conjunto de 10, son divisibles por 3 o por 5.
        /// </summary>
        public void DividerNumbers()
        {
             try
             {
                // Defining Variables
                int number = 0, CountDivider = 0;
                decimal division = 0;
                string enteredNumber = string.Empty;

                // requesting for the numbers
                Console.WriteLine("Enter a set of 10 numbers");

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"{i}: ");
                    enteredNumber = Console.ReadLine();

                    // Validate if the input is null
                    if (enteredNumber == string.Empty)
                    {
                        Console.WriteLine($"The input cannot be null, you must enter a number!");
                        // allows the user to enter a new number
                        i--;
                        continue;
                    }

                    // Validate if the input if a number
                    if (!int.TryParse(enteredNumber, out number))
                    {
                        Console.WriteLine($"Invalid input entered: {enteredNumber}, you must enter a number!");

                        // allows the user to enter a new number
                        i--;
                        continue;
                    }

                    // Divide the numbers by 5 
                    if (number % 3 == 0 || number % 5 == 0)
                    {
                        CountDivider++;
                    }
                }

                // Show the count of numbers dividers by 3 or 5
                Console.Write($"The are {CountDivider} divider by 3 or 5");
            }

            catch (Exception ex) 
            { 
                Console.WriteLine ($"The was an error during the run, details {ex.Message}");
            }
        }

        /// <summary>
        /// Class for:
        /// Desarrollar un programa que permita ingresar 10 números 
        /// y luego muestre la suma de los últimos 5 números ingresados.
        /// </summary>
        public void LastNumbers()
        {
            try
            {
                // Defining Variables
                int num1 = 0, sum = 0, num2 = 0;
                string input = string.Empty;

                // requesting for the numbers
                Console.WriteLine("Calculate the summary of the last five numbers");

                for (int i = 1;i <= 10;i++) 
                {
                    Console.Write($"{i}: ");
                    input = Console.ReadLine();

                    // Validate if the input is null
                    if (input == string.Empty)
                    {
                        Console.WriteLine($"The input cannot be null, you must enter a number!");
                        // allows the user to enter a new number
                        i--;
                        continue;
                    }

                    // Validate if the input if a number
                    if (!int.TryParse(input, out num1))
                    {
                        Console.WriteLine($"Invalid input entered: {input}, you must enter a number!");

                        // allows the user to enter a new number
                        i--;
                        continue;
                    }

                    // Sum the last five number entered
                    if (i > 5)
                    {
                        num2 = num1;
                        sum += num2;
           
                    }
                }

                Console.WriteLine($"The summary of the last 5 digits is: {sum}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"The was an error during the run, details {ex.Message}");
            }
        }
    }
}
