using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStudentMarks
{
    public class ProgressReport
    {

        public void Display(Student s)
        {
            int total = s.GetTotal();
            if (total < 80)
                Console.BackgroundColor = ConsoleColor.Yellow;
            PrintRow($"{s.Name}", $"{s.Maths}", $"{s.Physics}", $"{s.SportMarks()}", $"{total}");
            Console.ResetColor();
            PrintLine();



            // Console.WriteLine($"\t| Name: {s.Name}, Maths: {s.Maths}, Physics: {s.Physics}, Sports Marks: {s.SportMarks()}, Total: {total}  |");
        }

        static int tableWidth = 71;
        public static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

    }
    public interface ISportsMarks
    {
        int SportMarks();
    }
    public class Student : ProgressReport, ISportsMarks
    {
        public string Name { get; set; }
        public int Physics { get; set; }
        public int Maths { get; set; }

        int sportsMarks = 0;
        public int SportMarks()
        {

            int total = GetTotal();
            if (total > 100)
                sportsMarks = 20;
            else
                sportsMarks = 30;
            return sportsMarks;

        }

        public int GetTotal()
        {
            return Maths + Physics + sportsMarks;
        }

    }

    class Program
    {
        static List<Student> student = new List<Student>();
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 0; i++)
            {

                Student s = new Student();
                Console.WriteLine("\tEnter Name: ");
                s.Name = Console.ReadLine();
                Console.WriteLine("\tEnter Marks For Maths: ");
                s.Maths = int.Parse(Console.ReadLine());
                Console.WriteLine("\tEnter Marks For Physics: ");
                s.Physics = int.Parse(Console.ReadLine());
                student.Add(s);
                Console.Clear();

            }
            ProgressReport report = new ProgressReport();
            Console.WriteLine("\t\t-----------Student Details------------\n");
            Console.WriteLine();
            ProgressReport.PrintLine();
            ProgressReport.PrintRow("Name", "Maths", "Physics", "Sports Marks", "Total");
            ProgressReport.PrintLine();
            foreach (var item in student)
            {

                report.Display(item);
            }
            //ProgressReport.PrintLine();
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
