using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Menu  
    {
        public List<MenuItem> Meals { get; set; } 


        public  void loadMeals(MenuItem meal)
        {
            Meals.Add(meal);
        }
    }
}
