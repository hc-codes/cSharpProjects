using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Name
    {
        public string FirstName;
        public string LastName;

        public Name(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public void Run()
        {
            Name obj = new Name("Hariprasad", "C");
            Console.WriteLine("Name : " + obj.FullName());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}
