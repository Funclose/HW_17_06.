using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ALL_HW
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public  Book (string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}";
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode() ^ Author.GetHashCode();
        }

        public static bool operator ==(Book b1, Book b2)
        {
            return b1.Equals(b2);
        }
        public static bool operator !=(Book b1, Book b2)
        {
            return b1.Equals(b2);
        }

    }
}
