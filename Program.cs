using For_ALL_HW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_17_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadList readingList = new ReadList();

            Book book1 = new Book("Essenstialism", "Greg Makkeon");
            Book book2 = new Book("something", "always");
            Book book3 = new Book("1984", "George Orwell");

            readingList.AddBook(book1);
            readingList.AddBook(book2);
            readingList.AddBook(book3);



            

            Console.WriteLine("-------------------------");

            readingList.RemoveBook(book2);
            
            Console.WriteLine("-------------------------");
            readingList.Show();
            
            
            
        }
    }
}
