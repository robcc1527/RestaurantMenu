using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{

    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; } 
        public string Catagory { get; set; }
        public DateTime Datetime { get; set; }
        public int Calories { get; set; }



        public MenuItem(string name, string description, double price, string catagory, DateTime available, int calories)
        {
            Name = name;
            Description = description;
            Price = price;
            Catagory = catagory;
            Datetime = available;
            Calories = calories;
        }

    }
}
