using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    class Program
    {
        public static void Main()
        {
            //Person person = new Person();
            //Address address = new Address();
            //Console.WriteLine("Enter the Name: ");
            //person.Name = Console.ReadLine();
            //Console.WriteLine("Enter the Email: ");
            //person.Email = Console.ReadLine();
            //Console.WriteLine("Enter The Location: ");
            //person.Location = Console.ReadLine();
            //Console.WriteLine("Enter The City Name: ");
            //person.City = Console.ReadLine();
            //Console.WriteLine("Enter The State: ");
            //person.State = Console.ReadLine();
            //Console.WriteLine("Enter The Pincode: ");
            //person.Pincode = Console.ReadLine();
            //Console.WriteLine("Enter DOB");
            //person.DateOfBirth = Console.ReadLine();
            //Console.WriteLine(person.GetDetails());

            //Using Constructor
            Person p = new Person("abc","abc@mail.com");
            Address a = new Address("aaa", "aaa", "aaaaa", "123456");
            Console.WriteLine($"\nUsing 2 parameter Constructor Along with Address Constructor\n{p.GetDetailsForConstructor()}\n{a.GetAddress()}");
            Person p1 = new Person("xyz", "xyz@gmail.com", "28/08/2005");
            Address a1 = new Address("xxx","yyy","zzzzzz","121212");
            Console.WriteLine($"Using 3 parameter Constructor\n{p1.GetDetailsForConstructor()}\n{a1.GetAddress()}");

        }
    }
   
}
