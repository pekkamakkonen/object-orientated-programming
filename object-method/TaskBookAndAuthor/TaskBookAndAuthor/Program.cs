using System;
using Literature.TaskBookAndAuthor;

namespace TaskBookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Merkonomin matematiikka", "Saaranen", "Edita Publishing Oy", 40.10);
            book1.GetBook("Merkonomin matematiikka");
            book1.Price = 29.00;
            Console.WriteLine($"Uusi hinta: {book1.Price}");
            Book.ChangeTheme("Oppikirjat");
            Console.WriteLine("---");

            Book book2 = new Book("Markkinoinnin perusteet", "Lahtinen", "Avaintulos Oy", 50.00);
            book2.GetBook("Markkinoinnin perusteet");
            book2.Price = 31.00;
            Console.WriteLine($"Uusi hinta: {book2.Price}");
            Book.ChangeTheme("Oppikirjat");
            Console.WriteLine("---");

            book2.GetBook("Markkinoinnin ABC");
            Console.WriteLine("---");

            Author author1 = new Author("Saaranen", "1991-09-09", book1);
            author1.PrintAuthorInfo();
            Console.WriteLine("---");

            Author author2 = new Author("Lahtinen", "1996-08-27", book1);
            author2.PrintAuthorInfo();
            Console.WriteLine("---");

            Console.ReadKey();
        }
    }
}
