using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.CalculateNumbers
{
    /// <summary>
    /// Clase para calcular dos numeros intrducidos por el usuario si el primer número es más grande, calcule y muestre su suma y resta. 
    /// De lo contrario, calculará y mostrará su producto y cociente.
    /// </summary>
    public class CalculateNumbers
    {
        public void Calculate()
        {
            // Declaring the variables
            int num1 = 0, num2 = 0, substraction = 0, addition = 0;
            decimal division = 0, multiplication = 0;
            string FirstNumber = string.Empty, SecondNumber = string.Empty;

            try
            {
                // To get the first number
                Console.Write("Input the first number: ");
                FirstNumber = Console.ReadLine();

                // To validate if the user didn't enter an empty string for the first one
                if (string.IsNullOrEmpty(FirstNumber))
                {
                    Console.WriteLine("You must enter a number, the field cannot be null");
                    return;
                }

                // To validate if the user entered a valid number first one
                if (!int.TryParse(FirstNumber, out num1))
                {
                    Console.Write($"Invalid number input: {FirstNumber}");
                    return;
                }

                // To get the second number
                Console.Write("Input the second number: ");
                SecondNumber = Console.ReadLine();

                // To validate if the user didn't enter an empty string for the second one
                if (string.IsNullOrEmpty(SecondNumber))
                {
                    Console.WriteLine("You must enter a number, the field cannot be null");
                    return;
                }

                // To validate if the user entered a valid number first one 
                if (!int.TryParse(SecondNumber, out num2))
                {
                    Console.Write($"Invalid number input: {SecondNumber}");
                    return;
                }

                // In order to calculate
                if (num1 > num2)
                {
                    // To add up the numbers
                    addition = (num1 + num2);

                    // To subtract up the numbers
                    substraction = (num1 - num2);

                    Console.WriteLine($"The sum result is: {addition}");
                    Console.WriteLine($"The subtraction result is: {substraction}");

                }

                // To validate if the user didn't enter a 0 
                else if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("It's unable divide a number by 0");
                }

                else
                {
                    // To add up the numbers
                    division = (decimal)num2 / (decimal)num1; // (decimal) is used to convert the integers to decimals

                    // To subtract up the numbers
                    multiplication = (num1 * num2);

                    Console.WriteLine($"The division result is: {division:F2}");
                    Console.WriteLine($"The multiplication result is: {multiplication}");

                }

            }

            catch (Exception e)
            {
                Console.WriteLine($"Occured an error during the running: {e.Message}");
            }

            Console.ReadKey();
        }

    }
}
