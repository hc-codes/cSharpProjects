using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;

namespace Interface2
{
    class Member : Person, IMember
    {
        public string Membership { get; set; }
        public Member(string name, string dateOfBirth)
        {

        }
        public override string GetDetails()
        {
            string s = base.GetDetails() + ", class: "+ this.Membership;
            return s;
        }
    }
}
