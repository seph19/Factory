using System;
using System.Threading;

namespace Pizzeria
{
    class Program
    {
         static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("------Welcome to Pizza Competition-------");
            Console.WriteLine("Pizzaria A");
            Console.WriteLine("Pizzaria B");
            Console.Write("Please choose a Pizzaria(A/B):");
            var pizzaria = Console.ReadLine();
            if (pizzaria.ToLower() == "a" || pizzaria.ToLower() == "b")
            {
                PizzaType(pizzaria);
            }
            else
            {
                Console.WriteLine("Wrong Input! Please choose A or B only!");
                Thread.Sleep(2500);
                Start();
            }
        }

        public static void PizzaType(string pizzaria)
        {
            Console.Clear();
            Console.WriteLine("------Type of Pizza-------");
            Console.WriteLine("[1] Cheese Pizza");
            Console.WriteLine("[2] Clam Pizza");
            Console.WriteLine("[3] Veggie Pizza");
            Console.Write("Please choose what Type of Pizza you like:");
            var type = Console.ReadLine();
            var pizza = new Pizza();

            if (type == "1" || type == "2" || type == "3")
            {
                string style = "";
                switch (type)
                {
                    case "1":
                        style = "Cheese";
                        break;
                    case "2":
                        style = "Clam";
                        break;
                    case "3":
                        style = "Veggie";
                        break;
                }
                pizza = PizzariaStore.PizzariaTeam(pizzaria, type);

                var status = PizzaProcess.Process(pizza,style, pizzaria);

                if (status.ToLower() == "done")
                {
                    Console.Write("Do you want to make another order?Y/N:");
                    var input = Console.ReadLine();

                    if (input.ToLower() == "y")
                    {
                        Console.Clear();
                        Program.Start();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong Input! Please choose 1, 2 or 3!");
                Thread.Sleep(2500);
                Console.Clear();
                PizzaType(pizzaria);
            }
        }
    }
}
