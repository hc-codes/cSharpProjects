using System;
using System.IO;
using System.Speech.Synthesis;
using System.Threading;

namespace FileReadAndWrite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //StreamWriter stream = new StreamWriter("newFile.txt");
            //while (true)
            //{
            //    string str = Console.ReadLine();
            //    if (str.ToLower() == "q")
            //        break;
            //    stream.WriteLine(str);

            //}
            //stream.Flush();
            //stream.Close(); //Use this only 1 time.

            //SystemSounds.Hand.Play();
            FileStream f = new FileStream("Names.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter stream = new StreamWriter("Names.txt");
            StreamWriter stream = new StreamWriter(f);
            Console.WriteLine("Enter The Names of students or 'q' to quit");
            while (true)
            {
                string str = Console.ReadLine();
                if (str.ToLower() == "q")
                    break;
                stream.WriteLine(str);
            }
            stream.Flush();
            stream.Close();
            f.Close();
            f = new FileStream("Names.txt", FileMode.Open, FileAccess.Read);
            SpeechSynthesizer sp = new SpeechSynthesizer();
            //StreamReader sr = new StreamReader("newFile.txt");
            StreamReader sr = new StreamReader(f);
            Console.WriteLine("Welcome to your file\n");
            sp.Speak("Welcome to your file");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string s = sr.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            while (s != null)
            {
                Console.WriteLine("\t" + s);
                Console.Beep();
                Thread.Sleep(1500);
                if (s != null)
                    sp.Speak(s);
                s = sr.ReadLine();
            }
            s = null;
            sr.Close();
            f.Close();
            f = new FileStream("Names.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(f);
            //sr = new StreamReader("Names.txt");
            s = sr.ReadLine();
            Console.ResetColor();
            bool notFound = true;
            Console.WriteLine("Enter the name of student to be searched");
            string item = Console.ReadLine();

            while (s != null)
            {
                if (s == item)
                {
                    notFound = false;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Student named: {item} found in the file");
                    Thread.Sleep(1500);
                    sp.Speak($"Student named: {item} found in the file");
                    break;
                }
                s = sr.ReadLine();
            }
            if (notFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Student named: {item} not found in the file");
                sp.Speak($"Student named: {item} not found in the file");
            }
            Console.ResetColor();
            Console.WriteLine("\nEnd of the file...");
            sp.Speak("End of the file...");
            Console.Beep(1000, 3000);
            sr.Close();
        }
    }
}