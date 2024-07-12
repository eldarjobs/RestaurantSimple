
namespace task;

public class Dish
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    Category Category { get; set; }
    public Dish(int id, string name,double price)
    {
        ID = id;
        Name = name;
        Price = price;
    }
    public List<Dish> FindDishesByCategory(List<Dish> dishes, Category category)
    {

        List<Dish> newDishesList = dishes.Where(d => d.Category.ID == category.ID).ToList();
        return newDishesList;
    }
}