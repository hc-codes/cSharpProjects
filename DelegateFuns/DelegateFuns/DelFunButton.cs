using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFuns
{
   
    public delegate void OnClick();
    class Button
    {
        public OnClick OnClick;
        public string Text { get; set; }
        public Button()
        {
            OnClick += DefaultButtonClickEventHandler;
        }
        public void Display()
        {
            Console.WriteLine("----------------");
            Console.WriteLine($"|    {Text}     |");
            Console.WriteLine("----------------");
        }
        public void Click()
        {
            OnClick();
        }
        public void DefaultButtonClickEventHandler()
        {
            Console.WriteLine("Default Button Clicked");
        }
    }
    class DelFunButton
    {
        static void run()
        {
            Button b1 = new Button();
            b1.Text = "Click Me!";
            b1.Display();
            b1.Click();
            Console.WriteLine("yes/no");
            string inp = Console.ReadLine();
            if (inp == "yes")
            {
                b1.OnClick -= b1.DefaultButtonClickEventHandler;
                b1.OnClick += ButtonClicked;
            }
            else
                Console.WriteLine("Button not clicked");
            b1.Click();
        }
        static void ButtonClicked()
        {
            Console.WriteLine("Button Clicked");
        }
    }
}
