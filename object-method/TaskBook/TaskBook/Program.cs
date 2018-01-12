using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookMarketingAnIntroduction = new Book();
            bookMarketingAnIntroduction.Title = "Marketing An Introduction";
            bookMarketingAnIntroduction.Author = "Kotler Philip";
            bookMarketingAnIntroduction.Id = 12345;
            bookMarketingAnIntroduction.Price = 50.99;

            Book bookLakiopas = new Book("Lakiopas - juridiikan perusteet", "Suojanen", 209209, 37);

            Console.WriteLine(bookMarketingAnIntroduction.CompareBook(bookLakiopas));

            Console.ReadKey();
        }
    }
}
