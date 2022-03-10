using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* WebBrowser o = new WebBrowser();
             o.WebMenu();*/
    class WebBrowser
    {
        static FunClass obj = new FunClass();
        public static bool CheckUrl(string s)
        {
            Regex urlRegex = new Regex(@"(https:)?\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)");
            Console.WriteLine("address is:" + urlRegex.IsMatch(s));
            return urlRegex.IsMatch(s);
        }
        public void WebMenu() //call this function first
        {
            
            string dis = @"1. Navigate to a Website. -> Enter the url 2.Go Back 3.History 4.Clear History 5.Exit";
            string[] arr = new string[100];
            int c = 0;
            int rev=0;
            int flag = 0;
            int ch;
            do
            {
                Console.WriteLine(dis);
                Console.WriteLine("Enter A Choice:");
                ch = int.Parse(Console.ReadLine());
                {
                    switch (ch)
                    {
                        case 1:
                            Navigate(arr,ref c);
                           // Console.WriteLine(c);
                            rev = c;
                            c = c + 1;
                            break;
                        case 2:
                           // Console.WriteLine("rev=" + rev);
                            Back(arr,ref rev);
                            break;
                        case 3:
                            History(arr);
                            break;
                        case 4:
                            ClearHistory(arr);
                            Console.WriteLine("History Cleared");
                            break;
                        case 5:
                            Console.WriteLine("Exiting... Please Wait");
                            obj.funn();
                            flag = 1;
                            break;


                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine("Exited...Thank You For Using");
                    break;
                }
            } while (true);
        }
        static void Navigate(string [] arr,ref int c)
        {
            Console.WriteLine("Enter The Url -> : ");
            string s = Console.ReadLine();
            if (CheckUrl(s) == true)
            {
                Console.Write("Your Url Is Loading... Please Wait: ---> ");
                obj.fun();
                Console.WriteLine();
                arr[c] = s;
                System.Diagnostics.Process.Start(s);

            }
            else
            {
                Console.WriteLine("Invalid Url...Try Again");
                obj.funn();
            }
        }
        static void Back(string [] arr, ref int rev)
        {
            
            
            if (rev <= 0)
            {
                Console.WriteLine("No Previous Pages");
                
            }
            else
            {
                System.Diagnostics.Process.Start(arr[--rev]);
               
            }
            rev = rev - 1;
        }
        static void History(string [] arr)
        {
            foreach (var item in arr)
            {
                if (item != default)
                {
                    Console.WriteLine(item);

                }
                else
                {
                    Console.WriteLine("No More Pages From History");
                    break;
                }
            }
        }
        static void ClearHistory(string [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                    arr[i] = null;
                else
                    break;
            }
        }
    }
}

//using main the same program
#region
/*public static bool CheckUrl(string s)
{
    Regex urlRegex = new Regex(@"(https:)?\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)");
    Console.WriteLine("address is:" + urlRegex.IsMatch(s));
    return urlRegex.IsMatch(s);
}
static void Main(string[] args)
{
    string dis = @"1. Navigate to a Website. -> Enter the url
2.Go Back
3.History
4.Exit";
    var obj = new FunClass();
    string[] arr = new string[100];
    int c = 0;
    int rev;
    int flag = 0;
    int ch;
    do
    {
        Console.WriteLine(dis);
        Console.WriteLine("Enter A Choice:");
        ch = int.Parse(Console.ReadLine());
        {
            switch (ch)
            {

                case 1:
                    Console.WriteLine("Enter The Url -> : ");
                    string s = Console.ReadLine();
                    if (CheckUrl(s) == true)
                    {
                        Console.Write("Your Url Is Loading... Please Wait: ---> ");
                        obj.fun();
                        Console.WriteLine();
                        arr[c++] = s;
                        System.Diagnostics.Process.Start(s);
                        break;
                    }

                    Console.WriteLine("Invalid Url...Try Again");
                    obj.funn();
                    break;
                case 2:
                    rev = c;
                    --rev;
                    if (rev < 0)
                    {
                        Console.WriteLine("No Previous Pages");
                        break;
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(arr[--rev]);
                        break;
                    }

                case 3:
                    foreach (var item in arr)
                    {
                        if (item != default)
                        {
                            Console.WriteLine(item);

                        }
                        else
                        {
                            Console.WriteLine("No More Pages From History");
                            break;
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Exiting... Please Wait");
                    obj.funn();
                    flag = 1;
                    break;


            }
        }
        if (flag == 1)
        {
            Console.WriteLine("Exited...Thank You For Using");
            break;
        }
    } while (true);
}*/
#endregion