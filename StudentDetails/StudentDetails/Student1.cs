using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Student1 : Subject
    {
        private string name, id;
        public string Name { get; set; }
        public string Id { get => id; set => id = value; }

    }
}
