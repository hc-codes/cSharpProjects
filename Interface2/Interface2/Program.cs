using Inheritance;
using Interface2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInputForEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[20];
            Employee[] employees = new Employee[20];
            IMember[] members = new IMember[20];
            StaffMember staffs = new StaffMember("abc","777888");
            employees[0] = staffs;
            members[0] = staffs; //staffMember is not related to member cant store staff to member[].
            string ch = "";
            int c = 0;
            while (ch != "q")
            {
                Console.Write("'e':- For Employee, 'm':- For Memeber 'l':- For Listing 'q':- To Exit: ");
                ch = Console.ReadLine();
                switch (ch)
                {
                    case "e":
                        Employee e = EmployeeDetails();
                        people[c++] = e;
                        Console.WriteLine("\n\tEmployee Details Saved");
                        break;
                    case "m":
                        Person p = PersonDetails();
                        people[c++] = p;
                        Console.WriteLine("\n\tPerson Details Saved");
                        break;
                    case "l":
                        ListPeople(people);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ListPeople(Person[] people)
        {
            Console.WriteLine("\n\n\n\tList of people");
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i]==default)
                    break;
                else
                {
                    Console.Write($"\t {people[i].Name}\t{people[i].Email}\t{people[i].Address}\t{people[i].DateOfBirth}");
                    Console.WriteLine();
                }

            }
        }

        private static Employee EmployeeDetails()
        {

            Console.Write("\n\n\n\tName: ");
            string name = Console.ReadLine();
            Console.Write("\n\tDOB: ");
            string dob = Console.ReadLine();
            Employee e = new Employee(name, dob);
            Console.Write("\tEmail: ");
            e.Email = Console.ReadLine();
            Console.Write("\tAddress: ");
            e.Address = Console.ReadLine();
            Console.Write("\tDesignation: ");
            e.Designation = Console.ReadLine();
            Console.Write("\tSalary: ");
            e.Salary = double.Parse(Console.ReadLine());
            return e;
        }

        private static Person PersonDetails()
        {
            Console.Write("\n\n\n\tName: ");
            string name = Console.ReadLine();
            Console.Write("\n\tDOB: ");
            string dob= Console.ReadLine();
            Person p = new Person(name, dob);
            Console.Write("\tEmail: ");
            p.Email = Console.ReadLine();
            Console.Write("\tAddress: ");
            p.Address = Console.ReadLine();
            return p;
        }
    }
}
