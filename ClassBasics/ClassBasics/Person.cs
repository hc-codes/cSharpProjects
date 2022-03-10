using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    public class Person
    {
        private string name, email, dateOfBirth;
        private Address address = new Address();

        public Person() { }
        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public Person(string name, string email, string dateOfBirth) : this(name, email)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email { get => email; set => email = value; }
        public string Location { get => address.Location; set => address.Location = value; }
        public string City { get => address.City; set => address.City = value; }
        public string State { get => address.State; set => address.State = value; }
        public string Pincode { get => address.Pincode; set => address.Pincode = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string GetDetails()
        {
        
            string s = $"Name: {name}\nEmail: {email}\nAddress: {address.GetAddress()}\nDateOfBirth: {dateOfBirth}";
            return s;
        }
        public string GetDetailsForConstructor()
        {
            string s = $"Name: {name}\nEmail: {email}\nDateOfBirth: {dateOfBirth}";
            return s;
        }
        ~Person()
        {
            Console.WriteLine("Destructor For: " + this.name);
        }

    }
}
