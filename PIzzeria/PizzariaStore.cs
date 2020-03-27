using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class PizzariaStore
    {
        public static Pizza PizzariaTeam(string team,string type)
        {
            var pizza = new Pizza();
            if (team == "a")
            {
               pizza = PizzariaA(type);
            }
            else
            {
                pizza = PizzariaB(type);
            }

            return pizza;
        }

        public static Pizza PizzariaA(string type)
        {
            var veggies = new List<string>();
            veggies.Add( "Olives");
            veggies.Add("Onions");
            veggies.Add("Bell Peppers");

            var pizza = new Pizza()
            {
                Dough = "Thin Crust",
                Cheese = "Mozzarella",
                Sauce = "Cherry Tomato",
                Clam = "Frozen Clam",
                Veggies = veggies
            };

            var products = new Pizza();
            switch (type)
            {
                case "1": //cheese
                    products = PizzaProducts.CheesePizza(pizza.Dough, pizza.Cheese, pizza.Sauce, pizza.Veggies);
                    break;
                case "2": //clam
                    products = PizzaProducts.ClamPizza(pizza.Dough,pizza.Clam,pizza.Sauce,pizza.Cheese);
                    break;
                case "3": //clam
                    products = PizzaProducts.VeggiePizza(pizza.Dough, pizza.Cheese, pizza.Sauce, pizza.Veggies);
                    break;
            }

            return products;
        }
        public static Pizza PizzariaB(string type)
        {
            var veggies = new List<string>();
            veggies.Add( "Cucumber");
            veggies.Add("Onions");
            veggies.Add("Bell Peppers");

            var pizza = new Pizza()
            {
                Dough = "Deep Dish",
                Cheese = "Parmesan",
                Sauce = "Plum Tomato",
                Clam = "Fresh Clam",
                Veggies = veggies
            };

            var products = new Pizza();
            switch (type)
            {
                case "1": //cheese
                    products = PizzaProducts.CheesePizza(pizza.Dough, pizza.Cheese, pizza.Sauce, pizza.Veggies);
                    break;
                case "2": //clam
                    products = PizzaProducts.ClamPizza(pizza.Dough, pizza.Clam, pizza.Sauce, pizza.Cheese);
                    break;
                case "3": //veggie
                    products = PizzaProducts.VeggiePizza(pizza.Dough, pizza.Cheese, pizza.Sauce, pizza.Veggies);
                    break;
            }

            return products;
        }
    }
}
