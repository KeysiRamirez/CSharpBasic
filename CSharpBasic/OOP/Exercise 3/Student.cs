namespace CSharpBasic.OOP.Exercise_3
{
    /// <summary>
    /// Crea una clase Alumno con las propiedades Nombre, Matricula, Carrera y Calificaciones (una lista de enteros).
    /// Implementa un método CalcularPromedio que devuelva el promedio de las calificaciones.
    /// Implementa un método MostrarInformacion que imprima el nombre, la matrícula, la carrera y el promedio del alumno.
    /// Crea instancias de la clase Alumno, asigna valores a las propiedades y muestra la información.
    /// </summary>
    public class Student
    {
        #region "Attributes"

        private string _name;
        private int _studentId;
        private string _career;
        private List<int> _grades;

        #endregion

        #region "Properties"
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public string Career
        {
            get { return _career; }
            set { _career = value; }
        }

        public List<int> Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }
        #endregion

        #region "Methods"

        public void CalculateAverage()
        {
            try
            {
                if (_grades == null || !_grades.Any())
                {
                    Console.WriteLine("No grades available to calculate the average.");
                    return;
                }

                double average = _grades.Average();
                Console.WriteLine($"The average grade is: {average:F2}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while calculating the average: {e.Message}");
            }
        }

        public void ShowInformation()
        {
            try
            {
                Console.WriteLine($"Student's information: \nName: {_name} \nID: {_studentId} \nCareer: {_career}");
                CalculateAverage();
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while showing the information: {e.Message}");
            }
        }

        public void InputGrades()
        {
            try
            {
                _grades = new List<int>();

                Console.Write("Enter the number of grades: ");
                int numberOfGrades = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numberOfGrades; i++)
                {
                    Console.Write($"Enter grade {i}: ");
                    int grade = int.Parse(Console.ReadLine());
                    _grades.Add(grade);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while inputting grades: {e.Message}");
            }
        }

        #endregion
    }
}