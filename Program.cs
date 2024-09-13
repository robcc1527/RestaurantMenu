// See https://aka.ms/new-console-template for more information
using RestaurantMenu;

class Program
{
    public static void Main(string[] args)
    {
        var chickenSandwitch = new MenuItem("Chicken sandwitch", "chicken inside a bun", 11.99,"main", DateTime.Now, 540);

        Console.WriteLine(chickenSandwitch.Price);
    }
}