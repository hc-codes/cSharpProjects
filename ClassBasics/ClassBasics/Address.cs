using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    public class Address
    {
        private string location, city, state, pincode;
        public string Location { get=>location; set=>location=value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Pincode { get => pincode; set => pincode = value; }

        public Address() { }
        public Address(string location, string city, string state,string pincode)
        {
            this.location = location;
            this.city = city;
            this.state = state;
            this.pincode = pincode;
        }
        public string GetAddress()
        {
            string s = $"Location: {location}, City: {city}, State: {state}, Pincode: {pincode}";
            return s;
        }
    }
}
