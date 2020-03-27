using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Pizza
    {
        public Pizza()
        {
            Veggies = new List<string>();
        }
        public string Cheese { get; set; }
        public string Clam { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Veggies { get; set; }
    }
}
