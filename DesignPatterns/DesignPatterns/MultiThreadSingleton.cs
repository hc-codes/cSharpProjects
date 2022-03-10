using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintStudentdetails(), 
                () => PrintEmployeeDetails()
                );
            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            /*
             * Assuming Singleton is created from employee class
             * we refer to the GetInstance property from the Singleton class
             */
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void PrintStudentdetails()
        {
            /*
                         * Assuming Singleton is created from student class
                         * we refer to the GetInstance property from the Singleton class
                         */
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }




    /*
    *  Sealed restricts the inheritance
    */
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        /*
        * Private constructor ensures that object is not
        * instantiated other than with in the class itself
        */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static Singleton instance = null;
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
