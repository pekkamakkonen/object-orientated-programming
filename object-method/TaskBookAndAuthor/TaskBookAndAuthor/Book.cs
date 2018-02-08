using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBookAndAuthor
{
    class Book
    {
        //Fields
        public string Title;
        public readonly string Author;
        public string Publisher;
        private double _price;
        static string ThemeName;

        //Constuctor
        public Book()
        {
            Title = null;
            Author = null;
            Publisher = null;
            _price = 0.00;
        }

        public Book(string title, string author, string publisher, double price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            _price = price;
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 30)
                {
                    _price = value - (value * 0.1);
                }
                else
                {
                    _price = value;
                }
            }
        }

        //methods
        public void GetBook(string title)
        {
            if (Title == title)
            {
                Console.WriteLine($"Kirjan nimi: {Title}\nKirjailija: {Author}\nKustantaja: {Publisher}\nHinta: {_price}\nTeeman nimi: {ThemeName}");
            }
            else
            {
                Console.WriteLine("Kirjaa ei löytynyt.");
            }
        }

        public static void ChangeTheme(string theme)
        {
            ThemeName = theme;
        }

        public string AuthorValue
        {
            get
            {
                return Author;
            }
            
        }
    }
}
