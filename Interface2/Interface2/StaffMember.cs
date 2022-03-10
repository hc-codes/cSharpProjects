using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;

namespace Interface2
{
  
    class StaffMember : Employee, IMember
    {
        public string Membership { get; set; }
        public StaffMember(string name, string dateOfBirth) : base(name,dateOfBirth)
        {

        }
    }
}
