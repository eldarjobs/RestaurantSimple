using task.Entities;

namespace task.BusinessLogic;

public class Businesslogicservice
{
    public void AddDishtoMenu(List<Dish> menyu, Dish dish)
    {

        menyu.Add(dish);
    }
    public void AddOrder(List<Order> orders, Order order)
    {
        orders.Add(order);
    }

    public Order? GetOrderByID(List<Order> Orders, int id)
    {
        foreach (var item in Orders)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        throw new Exception("Order Not found");
    }
}
