using System;

namespace TaskBookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Merkonomin matematiikka", "Saaranen", "Edita Publishing Oy", 40.10);
            book1.GetBook("Merkonomin matematiikka");
            book1.Price = 29.00;

            Book.ChangeTheme("Oppikirjat");

            Console.WriteLine();
            book1.GetBook("Merkonomin matematiikka");

            Console.ReadKey();
        }
    }
}
