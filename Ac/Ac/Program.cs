using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ac
{
    public class MyRoom
    {
        private Ac ac=new Ac();
        
        public int Temperature { get; set; }
        public MyRoom()
        {
            this.Temperature = 25;
            ac.Controller.TempHigh = 27;
            ac.Controller.TempLow = 23;
            ac.AirConditioning += SetTemp;
            
        }

        public void SetTemp(int temp)
        {
            this.Temperature += temp;
            Console.WriteLine("Current Temp = " + this.Temperature);
        }
        public void Check()
        {
            ac.Sense(this.Temperature);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyRoom myRoom = new MyRoom();
            while (true)
            {
                string ch = Console.ReadLine();
                if (ch == "q")
                    break;
                myRoom.Check();
            }
        }
    }
}
