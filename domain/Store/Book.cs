using System;
using System.Text.RegularExpressions;

namespace Store
{
    public class Book
    {
        public int Id { get; }
        public string Isbn { get; }
        public string Description { get; }
        public string Author { get; }
        public string Title { get; }
        public decimal Price { get; }
        public Book(int id, string title, string isbn, string author, 
                    string description, decimal price)
        {
            Id = id;
            Title = title;
            Isbn = isbn;
            Description = description;
            Author = author;
            Price = price;
        }

        internal static bool IsIsbn(string s)
        {
            if (s == null)
                return false;

            s = s.Replace("-", "")
                .Replace(" ", "")
                .ToUpper();

            return Regex.IsMatch(s, @"ISBN\\{10}(\d{3})?$");

            
        }
    }

}

