using task.Entities;

namespace task;

public static class Extensions
{
    public static double CalculateDishSum(this List<Dish> dishes)
    {
        double CalculateSum = dishes.Sum(d => d.Price);
        return CalculateSum;
    }
}
