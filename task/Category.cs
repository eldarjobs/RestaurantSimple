using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task;

public class Category
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Dish> Dishes { get; set; }
    public Category(int id, string name)
    {
        ID = id;
        Name = name;
    }
}
