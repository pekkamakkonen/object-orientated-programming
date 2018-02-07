using System;

namespace TaskBookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Merkonomin matematiikka";
            book1.Author = "Saaranen, Kolttola, Pösö";
            book1.Publisher = "Edita Publishing Oy";
            book1.Price = 30.01;

            book1.GetBook("Merkonomin matematiikka");
            Book.ChangeTheme("Oppikirjat");

            Console.WriteLine();

            book1.GetBook("Merkonomin matematiikka");

            Console.ReadKey();
        }
    }
}
