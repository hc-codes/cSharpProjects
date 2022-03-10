using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScreenLib
{
    public class Screen
    {

        int tableWidth = 75;
        public void PrintLine()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t" + new string('-', tableWidth));
            Console.ResetColor();
        }

        public void PrintRow(params string[] columns)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine("\t" + row);
            Console.ResetColor();

        }
        public void RedPrint(params string[] columns)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (string row in columns)
            {
                Console.Write("\n\n\t\t\t\t" + row);
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        public void ChoicePrint()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\t\t\t\t" + "Enter your choice: ");
            Console.ResetColor();
        }

        internal string ReadPassword()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string pass = "";
            bool continueReading = true;
            while (continueReading)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                char p = consoleKeyInfo.KeyChar;

                if (p == '\r')
                    continueReading = false;
                else if (consoleKeyInfo.Key == ConsoleKey.Backspace)
                {
                    Console.Write("\b \b");
                    pass = pass.Remove(pass.Length - 1);
                }
                else
                {
                    Console.Write("*");
                    pass += p;
                }
            }
            Console.ResetColor();
            return pass;
        }
        internal void SuccessPrint(string msg)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n\n" + msg + " Successfully...\n");

            Console.ResetColor();
        }
        public void WaitAndClear()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void NormalPrint(params string[] columns)
        {
            Console.ResetColor();
            //Console.Write(s+"\n");
            foreach (string row in columns)
            {
                Console.Write("\n\n\t\t\t\t" + row);
            }

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
}
