using System;
using System.Collections.Generic;
using System.Text;
using Literature.TaskBookAndAuthor;

namespace TaskBookAndAuthor
{
    class Author
    {
        //fields
        public string Name;
        public string DateOfBirth;
        Book Book;

        //constructor
        public Author()
        {
            Name = null;
            DateOfBirth = null;
            Book = null;
        }

        public Author(string name, string dateOfBirth, Book book)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Book = book;
        }

        //methods
        public void PrintAuthorInfo()
        {
            Console.WriteLine($"Kirjailijan nimi: {Name}\nSyntymäaika: {DateOfBirth}\n\nKirjan tiedot:\n");

            if (Name == Book.Author)
            {
                Book.PrintBookInfo();
            }
            else
            {
                Console.WriteLine("Kirjailija ei ole kirjoittanut hakuehdoissa määritettyä kirjaa.");
            }
        }
    }
}

