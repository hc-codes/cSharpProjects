using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;


namespace ConsoleApp1
{
    class Employees
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public void ComputeSalary(Employees e)
        {
            Console.WriteLine($"Salary of {e.Name} is = {e.Salary * 12}");
        }

    }
    class Program
    {
        public static void Main()
        {
            //var e = new Employees();
            //var emp = new Employees[20];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter employee name and salary ");
            //    emp[i] = new Employees()
            //    {
            //        Name = Console.ReadLine(),
            //        Salary = int.Parse(Console.ReadLine())
            //    };
            //}
            //foreach (var item in emp)
            //{
            //    if (item?.Name == null)
            //        break;
            //    e.ComputeSalary(item);

            //}
            nestedList obj = new nestedList();
            obj.fun();

        }
    }
   
}











/* char[] c = "morning".ToCharArray();
            char[] ch = "bring".ToCharArray();
            char[] notFound = new char[ch.Length];
            char[] found = new char[ch.Length];

            int x = 0;
            int y = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                int f = 0;
                for (int j = 0; j < c.Length; j++)
                {
                    if (ch[i] == c[j])
                    {
                        f = 1;
                        found[y] = ch[i];
                        y++;
                        break;
                    }

                }
                if (f != 1)
                {
                    notFound[x] = ch[i];
                    x++;
                }
            }
            Console.WriteLine("Found");
            foreach (var item in found)
            {
                Console.WriteLine(item);

            }
            int diff = ch.Length - found.Length; //1
            int cut = c.Length - found.Length;  //morning - ring=4
            char[] del = new char[c.Length-notFound.Length];
            x = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if(notFound[])
            }
        }*/



/* static void DoThis()
        {
           *//* if (a == 1)
                return 1;*//*
            Console.WriteLine( DateTime.Now.ToString());
            DoThis();
        }*/







/*List<int> a = new List<int>();
            Console.WriteLine("Enter numbers");
            for(int i=0;i<5 ;i++ )
            {

                a.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Your List Is");
            for(int i = 0; i < a.Count; i++)
            {
                Console.Write(a[i] + " ");
            }*/
/*
                        var a = new dynamic[] {1, "a", 2, 3, 6,"Hello " };
                        var b = new dynamic[] { 2,"b", 2, 3, 6,"World" };
                        //          object ab = "a";
                        //            Console.WriteLine(ab.GetType()==typeof(string));
                        for (int i = 0; i < a.Length; i++)
                        {
                            if (a[i].GetType()!=typeof(string))
                                Console.WriteLine(a[i] + b[i]);
                            else
                                Console.WriteLine(a[i] + b[i]);
                        }*/



/*
var a = new object[] { 1, 2, 2, 3, 6 };
var b = new object[] { 2, 2, 2, 3, 6 };*/
//          object ab = "a";
//            Console.WriteLine(ab.GetType()==typeof(string));
/*for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine((int)a[i] + b[i]);*/
/* if (a[i].GetType() != typeof(string))
     Console.WriteLine((int)a[i] + (int)b[i]);
 else
     Console.WriteLine(a[i].ToString() + b[i].ToString());
*/
//}


/*  object obj = 6;
  dynamic dy = "test string";

  string strobj = (string)obj;
  Console.WriteLine(strobj.ToUpper());
  Console.WriteLine(dy.ToUpper());*/

/* int i = 12;
 Console.WriteLine(i.ToString());
 object obj = 6;
 Console.WriteLine((int)obj);*/



/* string s = "hello world";
             char[] c = s.ToCharArray();
             for (int i = 0; i < c.Length; i++)
             {
                 Console.WriteLine(c[i]);

             }
*/


/*string s = " \"hello\" ";
            Console.WriteLine(s);*/
/*Console.WriteLine("Enter number 1");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 2");
y = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 3");
z = int.Parse(Console.ReadLine());
*/
/*for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"5 * {0} = {1}", i, (i * 5));
}*/
// int n, sum = 0;


/*
            int i = 1;
            do
            {
                Console.WriteLine("5 * {0} = {1}", i, (i * 5));
                i++;
            } while (i<=10);
            */








/*  Console.WriteLine("Enter number 1");
             i=int.Parse(Console.ReadLine());
             Console.WriteLine("Enter number 2");
             j = int.Parse(Console.ReadLine());
             Console.WriteLine(i /j);
             Console.WriteLine(i + j);
             Console.WriteLine(i - j);
             Console.WriteLine(i * j);
             Console.WriteLine(i % j);

             Console.WriteLine("Enter number 1");
             x = float.Parse(Console.ReadLine());
             Console.WriteLine("Enter number 2");
             y = float.Parse(Console.ReadLine());
             Console.WriteLine(x / y);
             Console.WriteLine(x + y);
             Console.WriteLine(x - y);
             Console.WriteLine(x * y);
             Console.WriteLine(x % y);




              Console.WriteLine("Enter number 2");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine("and= "+ (x & y));
            if ((z < y) & (z > x))
                Console.WriteLine("z=big");
            //Console.WriteLine(x / y);
            //Console.WriteLine(x + y);
            //Console.WriteLine(x - y);
            //Console.WriteLine(x * y);
            //Console.WriteLine(x % y);
           */



// if else 
/* if (x == 1)
               Console.WriteLine("Monday");
           else if (x == 2)
               Console.WriteLine("Tuesday");
           else if (x == 3)
               Console.WriteLine("Wednesday");
           else if (x == 4)
               Console.WriteLine("Thursday");
           else if (x == 5)
               Console.WriteLine("Friday");
           else if (x == 6)
               Console.WriteLine("Saturday");
           else if (x == 7)
               Console.WriteLine("Sunday");
           else
               Console.WriteLine("Invalid Input");*/



//switch

/*
switch (x)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;

}*/




/*
           while (true)

           {
               Console.WriteLine("enter");
               string s = Console.ReadLine();
               if (s == "q")
                   break;
               else
               {
                   n = int.Parse(s);
                   sum += n;
               }
           }
           Console.WriteLine("sum = " + sum);*/
/*for(; ; )
{
    Console.WriteLine("enter");
    string s = Console.ReadLine();
    if (s == "q")
        break;
    else
    {
        n = int.Parse(s);
        sum += n;
    }
}
Console.WriteLine("sum = " + sum);*/

/*
int big = x > y ? x > z : x : y > z ? y : z ;

char c = 'c';
    int i= int.Parse(c.ToString());
*/


/*int big = 0;
if (x > big)
    big = x;
if (y > big)
    big = y;
if (z > big)
    big = z;*/
/*
            Console.WriteLine("big ="+ big);*/

/*for (int i=0;i<x; i++)
{
    Console.WriteLine(i);
}*/
/* string x = "javascript";
 switch (x)
 {
     case "javascript":
     case "php":
     case "Python":
         Console.WriteLine("Interpreted");
         break;
     case "java":
     case "c#":
         Console.WriteLine("Compiled");
         break;
     default:
         Console.WriteLine("Invalid Input");
         break;

 }
*/