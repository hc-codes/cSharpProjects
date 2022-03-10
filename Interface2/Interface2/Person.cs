using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface2;

namespace Inheritance
{
    public class Person
    {
        private string name, email, address, dateOfBirth;
        public Person() { }
        public Person(string name, string dateOfBirth)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }
        public Person(string name, string email, string address, string dateOfBirth) : this(name, dateOfBirth)
        {
            this.email = email;
            this.address = address;
        }
        public string Name { get => name; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string DateOfBirth { get => dateOfBirth; }

        // The virtual keyword stops the static binding ad switches to dynamic binding.
        public virtual string GetDetails()
        {
            
            string s = $"Name: {name}, Email: {email}, Address: {address}, DateOfBirth: {dateOfBirth}";
            return s;
        }
      
        ~Person()
        {
            Console.WriteLine("Destructor For: " + this.name);
        }

    }
}
