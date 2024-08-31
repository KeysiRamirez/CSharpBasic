using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpBasic.TriangleArea
{
    public class TriangleArea
    {
        /// <summary>
        /// Solicite al usuario ingresar un número entero "n" que represente la cantidad de triángulos a procesar.
        //Para cada triángulo, capture los valores de la base y la altura.
        //Calcule el área de cada triángulo utilizando la fórmula correspondiente.
        //Muestre en pantalla los datos de cada triángulo (base, altura y área).
        //Determine y reporte la cantidad de triángulos con un área superior a 12 unidades cuadradas.
        /// </summary>
        public void TriangleAreaCalculator()
        {
            try
            {
                // Defining the variables
                int TriangleBase = 0, TriangleHeight = 0, TriangleQuantity = 0, counter = 0;
                decimal TriangleArea = 0;

                Console.Write("Enter the quantity of triangles to calculate their areas: ");

                if (!int.TryParse(Console.ReadLine(), out TriangleQuantity))
                {
                    Console.WriteLine($"Invalid input entered: {TriangleQuantity}");
                    return;
                }

                for (int i = 1; i <= TriangleQuantity; i++)
                {
                    Console.Write($"Enter the triangle {i} base: ");
                    if (!int.TryParse(Console.ReadLine(), out TriangleBase))
                    {
                        Console.WriteLine($"Invalid input entered: {TriangleBase}");
                        continue;
                    }

                    Console.Write($"Enter the triangle {i} base: ");
                    if (!int.TryParse(Console.ReadLine(), out TriangleHeight))
                    {
                        Console.WriteLine($"Invalid input entered: {TriangleHeight}");
                        continue;
                    }

                    TriangleArea = (decimal)((TriangleBase * TriangleHeight) / 2);

                    Console.WriteLine($"The area is: {TriangleArea}, according to the data entered \n Base: {TriangleBase} and Height: {TriangleHeight}");

                    if (TriangleArea > 12)
                    {
                        counter++;
                    }

                }

                Console.WriteLine($"The triangles which their area is greater than 12 are: {counter}");

            } catch (Exception ex)
            
            { 
                Console.WriteLine($"The was an error during the execution: {ex.Message}"); 
            }
        }
    }
}
