using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ScreenLib;

namespace PatientManagement
{
    public class Hospital
    {
        Screen screen = new Screen();
        List<Patient> patients = new List<Patient>();
        private readonly string patientSavePattern = "{0},{1},{2}\n";
        private readonly char[] dlimiter = { ',' };
        public void HospitalMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Thread.Sleep(2000);
                Console.Clear();
                screen.PrintLine();
                screen.PrintRow("Hospital Menu");
                screen.PrintLine();
                screen.NormalPrint("1. Register new patient", "2. Search a patient", "3. Display all patients");
                Console.WriteLine();
                screen.ChoicePrint();
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        Search();
                        break;
                    case "3":
                        Display();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Register()
        {
            Thread.Sleep(2000);
            Console.Clear();
            FileStream file = new FileStream("patient.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);
            StringBuilder builder = new StringBuilder();
            Patient patient = new Patient();
            try
            {
                screen.NormalPrint("Enter Name:- ");
                patient.Name = Console.ReadLine();
                screen.NormalPrint("Enter Age:- ");
                patient.Age = int.Parse(Console.ReadLine());
                screen.NormalPrint("Enter Address:- ");
                patient.Address = Console.ReadLine();
                patients.Add(patient);
                foreach (var item in patients)
                {
                    string str = String.Format(patientSavePattern, item.Name, item.Age, item.Address);
                    builder.Append(str);
                }
                writer.Write(builder.ToString());
                writer.Flush();
            }
            catch (FormatException)
            {
                screen.RedPrint("Invalid Input Format!!!");
            }
            finally
            {

                if (writer != null)
                {
                    writer.Close();
                    file.Close();
                }
            }
        }

        private void Search()
        {
            Thread.Sleep(2000);
            Console.Clear();
            bool found = false;
            screen.NormalPrint("Enter Name to be Searched: ");
            string name = Console.ReadLine();
            using (FileStream file = new FileStream("patient.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamReader reader = new StreamReader(file);
                while (true)
                {
                    string pstr = reader.ReadLine();
                    if (pstr == null)
                    {
                        break;
                    }
                    
                    var p = new Patient();
                    string[] strArr = pstr.Split(dlimiter, StringSplitOptions.RemoveEmptyEntries);
                    string check = strArr[0];
                    if(check==name)
                    {
                        Console.WriteLine($"\n\n\t\t\tPatient: {name} Found!!!");
                        found = true;
                    }
                    
                    
                }
                
            }
            if(!found)
                Console.WriteLine($"\n\n\t\t\tPatient: {name} Not Found");
        }

        private void Display()
        {
            Thread.Sleep(2000);
            Console.Clear();
            FileStream file = new FileStream("patient.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            string s = reader.ReadLine();
            while (s != null)
            {
                screen.NormalPrint(s);
                s = reader.ReadLine();

            }
            reader.Close();
            file.Close();
        }
      

    }
}
