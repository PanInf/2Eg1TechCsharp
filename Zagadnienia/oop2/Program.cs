using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class User
    {
        public string Name;
        public int ID;

        public void Verify()
        {
            Console.WriteLine("Verify");
        }
        public void CheckAccount()
        {
            Console.WriteLine("Check account");
        }
        public void get_book_info()
        {
            Console.WriteLine("Get book info");
        }
    }
    internal class Book
    {
        public string title, Author, ISBN, Publication;

        public void Show_duedt()
        {
            Console.WriteLine("Due time");
        }
        public void Reservation_status()
        {
            Console.WriteLine("Reservation_status");
        }
        public void Feedback()
        {
            Console.WriteLine("Feedback");
        }
        public void Book_request()
        {
            Console.WriteLine("Book_request");
        }
        public void Renw_info()
        {
            Console.WriteLine("Renew info");
        }
    }
    internal class Librarian
    {
        public string Name, Password, SearchString;
        public int ID;
        public List<Book> listOfRentedBooks;

        public void Verify_librarian()
        {
            Console.WriteLine("Verified");
        }
        public void Search()
        {
            Console.WriteLine("Found");
        }

        public void RentBook()
        {

            /* TOTALNIE LUZNE ROZWAZANIA NA PRZYSZŁOŚĆ
             * Library_DataBase db = new Library_DataBase();
            Book ksiazka = new Book();
            db.Search();
            listOfRentedBooks.Add(ksiazka);*/

            Console.WriteLine("Rent Book");
        }
    }



    internal class Library_DataBase
    {
        public List<string> List_Of_Books = new List<string>();
        public Librarian lib;

        public void Add()
        {
            Console.WriteLine("Add");
        }
        public void Delete()
        {
            Console.WriteLine("Delete");
        }
        public void Update()
        {
            Console.WriteLine("Update");
        }
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Search()
        {
            Console.WriteLine("Search");
        }
        public void getLibrarian()
        {
            Console.WriteLine("Librarian: xxx");
        }

    }
    internal class LibraryManagmentSystem
    {

        public string UserType;
        public string Username; 
        public string Password;

        public void Login()
        {
            Console.WriteLine("Login");
        }
        public void Register()
        {
            Console.WriteLine("Register");
        }
        public void Logout()
        {
            Console.WriteLine("Logout");
        }
    }
    

    internal class Account
    {
        public bool no_borrowed_books, no_reserved_books, no_returned_books, no_lost_books, fine_amount;

        public void Calculate_fine()
        {
            Console.WriteLine("Fine");
        }
    }


    internal class Student
    {
        public string Class;
    }
    internal class Staff
    {
        public string Dept;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Show_duedt();
            book1.Feedback();

            Librarian libek = new Librarian();
            libek.Name = "Bartosz";
            //libek.setName("Bartosz");
            libek.ID = 123;
            libek.Verify_librarian();
            List<Book> lista = new List<Book>();
            lista.Add(book1);
            libek.listOfRentedBooks = lista;

            // I tyle testów może wystarczy : )

            Console.ReadKey();
        }
    }
}
