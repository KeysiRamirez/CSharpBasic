using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.OOP.Exercise_1
{
    /// <summary>
    /// Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: 
    /// cargar los valores de x e y, imprimir en que cuadrante se encuentra dicho punto (concepto matemático, 
    /// primer cuadrante si x e y son positivas, si x<0 e y>0 segundo cuadrante, etc.
    /// </summary>
    public class Quadrants
    {
        #region "Atributes"

        private int _xValue;
        private int _yValue;

        #endregion

        #region "Properties"

        public int x_Value
        {
            get { return _xValue; }

            set { _xValue = value; }
        }

        public int y_Value
        {
            get { return _yValue; }

            set { _yValue = value; }
        }
        #endregion

        #region "GetValues"
        public void GetValues()
        {
            Console.Write("Enter the value for X: ");
            _xValue = int.Parse(Console.ReadLine());

            Console.Write("Enter the value for Y: ");
            _yValue = int.Parse(Console.ReadLine());
        }

        #endregion
        #region "ShowQuadrants"

        public void ShowQuadrants()
        {
            if (_xValue > 0 && _yValue > 0)
            {
                Console.WriteLine($"The coordinates: ({_xValue}, {_yValue}) belong to the first quadrant.");
            }

            else if (_xValue < 0 && _yValue > 0)
            {
                Console.WriteLine($"The coordinates: ({_xValue}, {_yValue}) belong to the second quadrant.");
            }

            else if (_xValue < 0 && _yValue < 0)
            {
                Console.WriteLine($"The coordinates: ({_xValue}, {_yValue}) belong to the third quadrant.");
            }

            else
            {
                Console.WriteLine($"The coordinates: ({_xValue}, {_yValue}) belong to the fourth quadrant.");
            }
            #endregion
        }
    }
}
