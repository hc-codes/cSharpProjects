using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSample
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            for (int i = 0; i < 1; i++)
            {
                Employee e = new Employee();
                Console.WriteLine("Enter Name");
                e.Name = Console.ReadLine();
                Console.WriteLine("StartDate in the format d/m/yyyy");
                e.StartDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("EndDate in the format d/m/yyyy");
                string end = Console.ReadLine();
                if (!end.Equals(""))
                    e.EndDate = Convert.ToDateTime(end);
                emp.Add(e);

            }
            var total=TimeSpan.Zero;
            foreach (var item in emp)
            {
                Console.WriteLine($"Start Date: {item.StartDate}, End Date: {item.EndDate} , Total Working Days: {(item.EndDate-item.StartDate).Days}");
            }
            var now = DateTime.Now;
            foreach (var item in emp)
            {

                var diff = TimeSpan.Zero;
                if (item.EndDate != default)
                    diff += (item.EndDate - item.StartDate);
                else
                    diff += (now - item.StartDate);

                total += diff; 
            } 
            Console.WriteLine("Total Work Hours=" + total.TotalHours/24*8);

        }
    }
}
