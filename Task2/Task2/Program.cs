using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>();
            Book book1 = new Book("Nizami");
            Book book2 = new Book("Alex");
            Book book3 = new Book("Nizami");
            Book book4 = new Book("Jack");
            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
            list.Add(book4);


            CountOfBooks(CheckAuthor, list);

        }
        public static bool CheckAuthor(string author)
        {
            return author == "Nizami";
        }
        public static void CountOfBooks(Predicate<string> books,List<Book> list)
        { int count=0;
            foreach (Book item in list)
            {
                if (books(item.Author))
                {
                    count++;
                  
                   
                }
             
                        
            }
            Console.WriteLine(count);



        }
    }
}
