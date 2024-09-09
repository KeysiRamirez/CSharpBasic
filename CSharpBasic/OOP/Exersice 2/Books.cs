using System;

namespace CSharpBasic.OOP.Exercise_2
{
    /// <summary>
    /// Crea una clase Libro con las propiedades Titulo, Autor y Paginas.
    /// Implementa un método MostrarInformacion que imprima la información del libro.
    /// Implementa un método EsLargo que devuelva true si el libro tiene más de 500 páginas, 
    /// o false en caso contrario.
    /// </summary>
    public class Books
    {
        #region "Attributes"

        private string? _title;
        private string? _author;
        private int? _pages;

        #endregion

        #region "Properties" 
        public string? Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string? Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int? Pages
        {
            get { return _pages; }
            set
            {
                if (value == null || value <= 0)
                    throw new ArgumentException("The number of pages cannot be null or less than or equal to zero.");

                _pages = value;
            }
        }

        #endregion

        #region "ShowInformation Method"

        public void ShowInformation()
        {
            try
            {
                Console.Write("Enter the book's title: ");
                _title = Console.ReadLine();

                Console.Write("Enter the book's author: ");
                _author = Console.ReadLine();

                Console.Write("Enter the book's pages: ");
                _pages = int.Parse(Console.ReadLine());

                // To print the results
                Console.WriteLine($"The book's info is: \nTitle: {_title} \nAuthor: {_author} \nTotal Pages: {_pages}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while showing the information: {e.Message}");
            }
        }
        #endregion

        #region "IsLong Method"

        public bool IsLong()
        {
            try
            {
                if (_pages.HasValue && _pages.Value > 500)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while checking if the book is long: {e.Message}");
                return false;
            }
        }
        #endregion
    }
}
