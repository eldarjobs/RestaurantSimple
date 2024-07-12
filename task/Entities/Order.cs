namespace task.Entities;

public class Order : BaseEntity
{

    public List<Dish> Dishes { get; set; }

    public double TotalPrice => Dishes.Sum(d => d.Price);

    public Order(int id)
    {
        id = Id;
    }
}
