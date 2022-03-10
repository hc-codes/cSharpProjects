using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class School
    {
        private string name; //location, state, pincode;
        private string id;
       /* public School()
        {
            
            location = "Thrissur";
            state = "Kerala";
            pincode = "688588";
        }*/

        public string SchoolName { get; set; } = "newSchool";
        public string Id { get; set; } = "4524454";

        /*public string GetAddress()
        {
            string s = $"School: {name}, Location: {location}, State: {state}, Pincode: {pincode}";
            return s;
        }*/
        public string GetName()
        {
            return SchoolName;
        }
        public void GetStudentDetails()
        {
            Student s = new Student();
            s.GetDetails();
        }
    }
}
