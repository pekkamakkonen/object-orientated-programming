using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Marketing An Introduction";
            book1.Author = "Kotler Philip";
            book1.Id = 12345;
            book1.Price = 50.99;

            Book book2 = new Book("Lakiopas - juridiikan perusteet", "Suojanen, Savolainen, Korte", 209209, 35.76);

            book1.PrintBookInfo();
            book2.PrintBookInfo();

            Console.WriteLine(book1.CompareBook(book2));
            Console.ReadKey();
        }
    }
}
