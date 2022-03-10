using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        Book[] books = new Book[10];

        public void Read()
        {
            for (int i = 0; i < 1; i++)
            {
                var b = new Book();
                Console.WriteLine("Book Name");
                b.Name = Console.ReadLine();
                Console.WriteLine("Author Name");
                b.Author = Console.ReadLine();
                Console.WriteLine("Price");
                b.Price = int.Parse(Console.ReadLine());
                books[i] = b;

            }
        }

        internal void View()
        {
            foreach (var book in books)
            {
                if (book?.Name != null)
                    Console.WriteLine($"\n\tBook Name: {book.Name}, Author: {book.Author}, Price: {book.Price}");
            }
        }

        internal void Edit()
        {
            Console.WriteLine("Enter the Name of book to be Edited From the Below List: ");
            View();
            string name = Console.ReadLine();
            int f = 0;
            for (int i = 0; i < 10; i++)
            {
                if (books[i] == null)
                    continue;
                if (books[i].Name == name)
                {
                    f = 1;
                    Console.WriteLine("\n\n\n\t\t-----EDIT MENU-----");
                    Console.WriteLine("\t1. Edit Name 2. Edit Email 3.Edit Dob ");
                    int c = int.Parse(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine("\tEnter New Book Name");
                            books[i].Name = Console.ReadLine();
                            Console.WriteLine("Edit Name Successful </>.");

                            break;
                        case 2:
                            Console.WriteLine("\tEnter New Author Name");
                            books[i].Author = Console.ReadLine();
                            Console.WriteLine("Edit Author Successful </>.");
                            break;
                        case 3:
                            Console.WriteLine("\tEnter New DOB");
                            books[i].Price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Edit Price Successful </>.");
                            break;

                        default:
                            break;
                    }
                }
            }
            if (f == 0)
                Console.WriteLine("Book Not Found");
        }
        void Menu()
        {
            Book b1 = new Book();
            while (true)
            {
                Console.WriteLine("1. Enter Book Details 2. Display Book Details 3. Edit Book Details or 'q' To Exit");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        b1.Read();
                        break;
                    case "2":
                        b1.View();
                        break;
                    case "3":
                        b1.Edit();
                        break;

                    default:
                        break;
                }
            }
        }
    }
    class Stack
    {
        int top = 0;
        int[] stack = new int[10];
        void Push()
        {
            if (top == stack.Length-1)
            {
                Console.WriteLine("\nStack Full. Pop one or more elements to push!!!");
                return;
            }
            Console.WriteLine("Enter the element to be pushed");
            stack[top++] = int.Parse(Console.ReadLine());
        }
        void Pop()
        {
            if(top == 0)
            {
                Console.WriteLine("\nStack Already Empty !!!");
                return;
            }
            int popedElement = stack[--top];
            Console.WriteLine("\nElement Poped: " + popedElement);
        }
        void View()
        {
            if(top==0)
            {
                Console.WriteLine("\tNo elements in the stack --- Stack Empty !!!\n");
                return;
            }
            Console.WriteLine("\n\tStack Elements ...\n");
            Console.WriteLine("\t\t__");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine("\t\t"+stack[i] + " ");
            }
            Console.ResetColor();
            Console.WriteLine("\t\t__\n");

        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n\t1. Push 2. Pop 3. View Stack or 'q' to quit");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        Push();
                        break;
                    case "2":
                        Pop();
                        break;
                    case "3":
                        View();
                        break;
                    case "q":
                        Console.WriteLine("\tExited Successfully...");
                        break;
                }

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Menu();
          

        }

    }
}









