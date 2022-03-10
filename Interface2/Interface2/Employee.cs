using Interface2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
       // public Employee() { }
        public Employee(string name, string dateOfBirth) : base(name, dateOfBirth)
        {

        }
        public Employee(string name, string email, string address, string dateOfBirth) :this(name,dateOfBirth) //base(name, email, address, dateOfBirth)
        {
            this.Email = email;
            base.Address = address;

        }
        public Employee(string name, string email, string address, string dateOfBirth, double salary, string designation) : this(name, email, address, dateOfBirth) //base(name, email, address, dateOfBirth)
        {
            this.Salary = salary;
            this.Designation = designation;
        }

        // ovrerride can be only used if there is a method with same definition in base class.
        public override string GetDetails()
        {
            string s =  $"{base.GetDetails()}, Salary: {Salary}, Designation: {Designation}";
            return s;
        }
    }
}
