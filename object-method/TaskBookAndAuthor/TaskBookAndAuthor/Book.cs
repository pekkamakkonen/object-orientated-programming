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
        public double Price;
        static string themeName;

        //Constuctor
        public Book()
        {
            Title = null;
            Author = null;
            Publisher = null;
            Price = 0.00;
        }

        public Book(string title, string author, string publisher, double price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Price = price;
        }

        //methods
        public void GetBook(string title)
        {
            if(Title == title)
            {
                Console.WriteLine($"Kirjan nimi: {Title}\nKirjailija: {Author}\nKustantaja: {Publisher}\nHinta: {Price}\nTeeman nimi: {themeName}");
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
