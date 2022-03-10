using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event1
{
    public delegate void Toggle(bool state);
    public class Fan
    {
        public void Turn(bool onOrOff)
        {
            if (onOrOff)
                TurnOn();
            else
                TurnOff();
        }

        private void TurnOff()
        {
            Console.WriteLine("Its Too Hot");
        }

        private void TurnOn()
        {
            Console.WriteLine("Wind Has Come !!!");
        }
    }
    public class Blub
    {
        public void Turn(bool onOrOff)
        {
            if (onOrOff)
                TurnOn();
            else
                TurnOff();
        }

        private void TurnOff()
        {
            Console.WriteLine("Darkness");
        }

        private void TurnOn()
        {
            Console.WriteLine("Then there was light !!!");
        }
    }
    public class Switch
    {
        public event Toggle Pushed;
        private bool state;
        public void Push()
        {
            this.state = !this.state;
            if (this.Pushed != null)
            {
                this.Pushed(this.state);
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Switch s = new Switch();
            Blub b = new Blub();
            Fan f = new Fan();
            s.Pushed += b.Turn ;
            s.Pushed += f.Turn;

            while (true)
            {
                string ch = Console.ReadLine();
                if (ch != "q")
                    s.Push();
                else
                    break;
            }
        }
    }
}
