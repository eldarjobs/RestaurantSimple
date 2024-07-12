namespace task.Entities;

public class Restaurant : BaseEntity
{
    public string Name { get; set; }

    public string Adress { get; set; }
    public List<Dish> Menu { get; set; }
    public List<Order> Orders { get; set; }

    public Restaurant(string name)
    {
        Name = name;
        Menu = new List<Dish>();
        Orders = new List<Order>();
    }

}