using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBookAndAuthor
{
    class Book
    {
        //Fields
        public string Title;
        public string Author;
        public string Publisher;
        private double _price;
        static string themeName;

        //Constuctor
        public Book()
        {
            Title = null;
            Author = null;
            Publisher = null;
            _price = 0.00;
        }

        public Book(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Price = _price;
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value > 30)
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
            if(Title == title)
            {
                Console.WriteLine($"Kirjan nimi: {Title}\nKirjailija: {Author}\nKustantaja: {Publisher}\nHinta: {Math.Round(Price, 2)}\nTeeman nimi: {themeName}");
            }
            else
            {
                Console.WriteLine("Kirjaa ei löytynyt.");
            }
        }
        
        public static void ChangeTheme(string theme)
        {
            themeName = theme;
        }
    }
}
