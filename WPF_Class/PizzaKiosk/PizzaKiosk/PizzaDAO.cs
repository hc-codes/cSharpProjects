using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKiosk
{
    public class PizzaDAO
    {
        public static List<string> GetPizzaSize()
        {
            var doughSize = new List<string>() { "6\"", "8\"", "10\"", "12\"", "14\"", "16\"" };
            return doughSize;
        }
        public static List<string> GetPizzaShape()
        {
            var pizzaShape = new List<string>() { "Round ", "Oval", "Triangle", "Rectangle" };
            return pizzaShape;
        }
        public static List<string> GetDoughThickness()
        {
            var doughThickness = new List<string>() { "Thin", "Thick" };
            return doughThickness;
        }
        public static List<string> GetDoughType()
        {
            var doughType = new List<string>() { "Nepolitan", "Hand Tossed", "Double-Dough", "Flatbread" };
            return doughType;
        }
        public static List<string> GetCheese()
        {
            var cheeses = new List<string>() { "Bire", "Feta", "Gouda", "Ricotta", "Parnesan", "Mozzarella" };
            return cheeses;
        }
        public static List<string> GetSauces()
        {
            var sauces = new List<string>() { "Pesto", "White Garlic", "Marinara", "Pizza" };
            return sauces;
        }
        public static List<string> GetToppings()
        {
            var toppings = new List<string>() { "Pepperoni","Chicken Sausage","Beef Sausage",
                "Oninon","Tomato","Mushroom","Chicken","Capsicum","Anchovies",
                "Olive","Salami","Sweet Corn","Bacon","Broccoli"};
            return toppings;
        }

    }
}
