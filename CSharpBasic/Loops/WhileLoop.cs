using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpBasic.Loops
{
    public class WhileLoop
    {
        /// <summary>
        /// Class for:
        /// a partir de una secuencia de 10 números enteros, calcule y muestre la suma y el promedio aritmético de dichos números.
        /// </summary>
        public void SumAndAverage()
        {
            try
            {
                // Defining variables
                int number = 0, sum = 0, increaser = 1;
                decimal average = 0;
                string enteredNumber = string.Empty;

                // // requesting for the numbers
                Console.WriteLine("Enter a set of 10 numbers");

               while (increaser <= 10)
               {
                    Console.Write($"{increaser}: ");
                    enteredNumber = Console.ReadLine();

                    // Validate if the input is null
                    if (enteredNumber == string.Empty)
                    {
                        Console.WriteLine($"The input cannot be null, you must enter a number!");
                        // allows the user to enter a new number
                        continue;
                    }

                    // Validate if the input if a number
                    if (!int.TryParse(enteredNumber, out number))
                    {
                        Console.WriteLine($"Invalid input entered: {enteredNumber}, you must enter a number!");

                        // allows the user to enter a new number
                        continue;
                    } 

                    // Sum the values
                    else
                    {
                        sum += number;
                        increaser++;
                    } 
               }

               // Calculate the average
               average = ((decimal)sum /*To convert the sum into decimal*/ / 10);
               
               // Output the results
               Console.WriteLine($"The sum is: {sum}");
               Console.WriteLine($"The average is: {average}");

            }

            catch (Exception ex) 
            { 
              Console.WriteLine($"The was an error dunring the execution: {ex}"); 
            }
        }

        /// <summary>
        /// Crear un programa que cuente cuántas piezas de hierro de un lote,
        /// dentro de un rango específico de longitud, son aptas para fabricar perfiles.
        /// </summary>
        public void BatchPieces() 
        {
            try
            {
                // defining the variables
                int increaser = 1, quantity = 0, qualifiedPieces = 0;
                decimal height = 0;
                string quantityEnter = string.Empty, heightEntered = string.Empty;

                // Requesting for the height value
                Console.Write("Input the quantity of pieces: ");
                quantityEnter = Console.ReadLine();

                // Validate if the input is null
                if (quantityEnter == string.Empty)
                {
                    Console.WriteLine($"The input cannot be null, you must enter a number!");
                    // allows the user to enter a new number
                    return;
                }

                // Validate if the input if a number
                if (!int.TryParse(quantityEnter, out quantity))
                {
                    Console.WriteLine($"Invalid input entered: {quantity}, you must enter a number!");

                    // allows the user to enter a new number
                    return;
                }

                while (increaser <= quantity) 
                {
                   // Requesting for the height value
                    Console.Write($"Input the piece {increaser} height: ");
                    heightEntered = Console.ReadLine();

                    // Validate if the input is null
                    if (heightEntered == string.Empty)
                    {
                        Console.WriteLine($"The input cannot be null, you must enter a number!");
                        // allows the user to enter a new number
                        continue;
                    }

                    // Validate if the input if a number
                    if (!decimal.TryParse(heightEntered, out height))
                    {
                        Console.WriteLine($"Invalid input entered: {increaser}, you must enter a number!");

                        // allows the user to enter a new number
                        continue;
                    }

                    if (height >= 1.20m && height <= 1.30m)
                    {
                        qualifiedPieces++;
                    }

                    increaser++;
                }

                // Output the quatity of pieces are able to use
                Console.WriteLine($"The total of pieces able to use is: {qualifiedPieces}");
            }

            catch (Exception ex) 
            {
                Console.WriteLine($"The was an error during the execution: {ex}");
            }

        }

    }
}