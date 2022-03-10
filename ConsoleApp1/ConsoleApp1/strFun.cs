using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class strFun
    {
        public void fun()
        {
            string str = "This String is very nice";
            Console.WriteLine("Upper==" + str.ToUpper());
            Console.WriteLine("Lower==" + str.ToLower());
            Console.WriteLine("replace==" + str.Replace(' ', '_'));
            Console.WriteLine("replace==" + str.Replace("string", "String"));
            Console.WriteLine("index==" + str.IndexOf('r'));
            Console.WriteLine("remove==" + str.Remove(5, 0));
            Console.WriteLine("substr==" + str.Substring(5));
            Console.WriteLine("len==" + str.Length);
            var c = new string[] { "is" };
            var words = str.Split();
            var w = str.Split(c, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("SPLIT....");
            foreach (var item in w)
            {
                Console.WriteLine(item);
            }
        }
             public void countSpace()
            {
                string s = "a b c d  d";
                int cp = 0;
                foreach (var item in s)
                {
                    if (item == ' ')
                        cp++;
                }
                Console.WriteLine(cp);
            }
            
            public void strSplit()
        {
            string student = "HARIPRASAD | HARIPRASAD@GMAIL.COM | 000000000";
            var sp = student.Split('|');
            foreach (var item in sp)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("1.NAME, 2.MAIL 3.PHONE");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(sp[n - 1]);
        }
    }
}
