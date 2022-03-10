using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class NewClass
    {
        public void Add(int x, int y,  ref int a,  ref int b)
        {
            a = x + y;
            b = x - y;
           
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b=0;
            NewClass o1 = new NewClass();
            o1.Add(5,6, ref a, ref b); //11
            Console.WriteLine(a+" "+b);
            
           

        }
       
    }
}






//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    delegate int Change(int n);
//    class NewClass
//    {
//        public void CallFun()
//        {
//            fun();
//        }
//        private void fun()
//        {
//            Console.WriteLine("HEllo");
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            NewClass o1 = new NewClass();
//            o1.CallFun();
//            //Console.WriteLine(Add(5));
//            //Console.WriteLine(Sub(5));
//            Change obj = new Change(Add);
//            Console.WriteLine(obj(10));
//            Change obj1 = new Change(Sub);
//            Console.WriteLine(obj1(200));


//        }
//        public static int Add(int n)
//        {
//            return n + 100;
//        }
//        public static int Sub(int n)
//        {
//            return n - 100;
//        }
//    }
//}
