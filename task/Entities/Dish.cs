namespace task.Entities;

public class Dish : BaseEntity
{
    public string Name { get; set; }
    public double Price { get; set; }
    Category Category { get; set; }
    public Dish(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
    public List<Dish> FindDishesByCategory(List<Dish> dishes, Category category)
    {

        List<Dish> newDishesList = dishes.Where(d => d.Category.Id == category.Id).ToList();
        return newDishesList;
    }
}