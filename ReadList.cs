using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ALL_HW
{
    internal class ReadList
    {
        private List<Book> books = new List<Book>();


        public bool Contains(Book book)
        {
            return books.Contains(book);
        }
        public void AddBook(Book book)
        {
            if (!books.Contains(book))
            {
                books.Add(book);
                Console.WriteLine(book);
            }
            else
            {
                throw new Exception($"The book '{book.Title}' by {book.Author} is already in the list.");
            }
        }

        public void RemoveBook(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                
            }
            else
            {
                throw new Exception($"i can't remove this book: {book.Title}");
            }
        }
        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Count)
                {
                    return books[index];
                }

                else
                {
                    throw new Exception("error in indeksator");
                }
            }
        }
        public void Show()
        {
            if(books.Count == 0) 
            {
                throw new Exception("error! list  is empty");
            }
            else
            {
                
                foreach (Book book in books) 
                {
                    Console.WriteLine(book); 
                }
            }
        }
    }
}
