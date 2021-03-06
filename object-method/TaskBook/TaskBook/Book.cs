﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBook
{
    class Book
    {
        //Fields
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        //Constuctor
        public Book()
        {
            Title = null;
            Author = null;
            Id = 0;
            Price = 0.00;
        }

        public Book(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;
        }

        //Methods
        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan nimi: {Title}\nKirjailijan nimi: {Author}\nID: {Id}\nHinta {Price}");
            Console.WriteLine();
        }

        public string CompareBook(Book book)
        {
            if(this.Price > book.Price)
            {
                return ($"{Title} on kalliimpi kuin {book.Title} -kirja.");
            }
            else
            {
                return ($"{book.Title} on kalliimpi kuin {Title} -kirja.");
            }
        }
    }
}
