using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task;

public static class Extensions
{
    public static double CalculateDishSum(this List<Dish> dishes)
    {
        double CalculateSum = dishes.Sum(d => d.Price);
        return CalculateSum;
    }


}
