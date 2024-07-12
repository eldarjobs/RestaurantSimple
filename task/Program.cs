using task.BusinessLogic;
using task.Entities;

        //inmutedable  what? is this?--->
public static class Program
{
    public static void Main(string[] args)
    {
        Businesslogicservice service = new Businesslogicservice();
        Restaurant restaurant = new Restaurant("McDonald's");

        Category category = new Category(1, "Fast Food");
        Category category2 = new Category(2, "Drinks");
        Dish dish = new Dish(1, "Big Mac", 10);
        Dish dish2 = new Dish(2, "Coca Cola", 5.5);


        service.AddDishtoMenu(restaurant.Menu, dish);

        // Example of displaying the menu
        Console.WriteLine($"Menu for {restaurant.Name}:");
        foreach (var item in restaurant.Menu)
        {
            Console.WriteLine($"- {item.Name} ({item.Price})");
        }
    }
}
