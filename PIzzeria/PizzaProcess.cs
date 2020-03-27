using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pizzeria
{
    public class PizzaProcess
    {
        public static string Process(Pizza pizza,string style,string team)
        {
            Prepare(pizza, style);
            Bake();
            Cut();
            var status = Box(team);
            return status;
        }
        public static void Prepare(Pizza pizza,string style)
        {
            Console.WriteLine($"Preparing Pizzeria A Style {style} Using");
            switch (style)
            {
                case "Cheese":
                    Console.WriteLine($"Dough: {pizza.Dough}, Cheese: {pizza.Cheese}, Sauce: {pizza.Sauce}, Veggies:  {String.Join(",",pizza.Veggies)}");
                    break;
                case "Clam":
                    Console.WriteLine($"Dough: {pizza.Dough}, Clam: {pizza.Clam}, Sauce: {pizza.Sauce}, Cheese: {pizza.Cheese}");
                    break;
                case "Veggie":
                    Console.WriteLine($"Dough: {pizza.Dough}, Sauce: {pizza.Sauce}, Veggies:  {String.Join(",", pizza.Veggies)}");
                    break;
            }
        }

        public static void Bake()
        {
            Thread.Sleep(6000);
            Console.WriteLine("Baking at 135 degree Celsius for 25 minutes");
        }

        public static void Cut()
        {
            Thread.Sleep(8500);
            Console.WriteLine("Cutting into diagonal pieces");
        }

        public static string Box(string team)
        {
            Thread.Sleep(3500);
            var color = "";
            if (team == "a")
            {
                color = "Red";
            }
            else
            {
                color = "Green";
            }
            Console.WriteLine($"Putting pizza in {color} box");
            Thread.Sleep(5500);

            return "Done";
        }
    }
}
