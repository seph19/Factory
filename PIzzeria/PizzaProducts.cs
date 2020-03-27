using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class PizzaProducts 
    {
        
        public static Pizza CheesePizza(string dough, string cheese, string sauce, List<string> veggies)
        {
           var pizza = new Pizza()
           {
               Dough = dough,
               Cheese = cheese,
               Sauce = sauce,
               Veggies = veggies
           };

           return pizza;
        }

        public static Pizza ClamPizza(string dough,string clam, string sauce, string cheese)
        {
            var pizza = new Pizza()
            {
                Dough = dough,
                Cheese = cheese,
                Sauce = sauce,
                Clam = clam
            };

            return pizza;
        }

        public static Pizza VeggiePizza(string dough, string cheese, string sauce, List<string> veggies)
        {
            var pizza = new Pizza()
            {
                Dough = dough,
                Cheese = cheese,
                Sauce = sauce,
                Veggies = veggies
            };

            return pizza;
        }
    }
}
