//using System.Xml.Linq;
//using task;

//Restaurant class'ın xüsusiyyətləri:
//Name
//Address 
//Menu (restoranın menyusu, yəni Dish obyektlərinin siyahısı)
//Orders (verilən sifarişlərin siyahısı)

//Not: Name property olmadan Restaurant class'dan instance alına bilməsin

//Restaurant class'ın davranışları(methods):
//Restaurant class'da, Menuya yemək əlavə edən bir method yazın (məsələn, AddDishtoMenu or AddDish).
//Restaurant class'da, Sifarişlər listinə, sifariş əlavə edən bir method yazın (məsələn, PlaceOrder).
//Restaurant class'da, OrderId ilə sifarişlər listindən həmin Id'ə sahib Orderi(əgər varsa)return edən bir method yazın (məsələn, PlaceOrder).
using System.Data;

namespace task;

public class Restaurant
{
    public int Id { get; set; }
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

    public void AddDishtoMenu(Dish dish)
    {

        Menu.Add(dish);
    }
    public void AddOrder(Order order)
    {
        Orders.Add(order);
    }

    public Order GetOrderByID(int id)
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