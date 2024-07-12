using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace task;

public class Order
{
    public int Id { get; set; }

    public List<Dish> Dishes { get; set; }

    public double TotalPrice =>Dishes.Sum(d => d.Price);

    public Order(int id)
    {
        id = Id;
    }
}
