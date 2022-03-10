using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class Student : School
    {
        private string name, email, dateOfBirth, schoolName;
        // private Address address = new Address();
        public Student()
        {

        }
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email { get => email; set => email = value; }
        //public string Location { get => address.Location; set => address.Location = value; }
        //public string City { get => address.City; set => address.City = value; }
        //public string State { get => address.State; set => address.State = value; }
        //public string Pincode { get => address.Pincode; set => address.Pincode = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
      //  public string SchoolName { get => schoolName; set => schoolName = value; }

        public string GetDetails()
        {
            
            string s = $"Name: {name}\nEmail: {email}\nSchool: {GetName()}\nDateOfBirth: {dateOfBirth}";
            return s;
        }
      
    }
}
