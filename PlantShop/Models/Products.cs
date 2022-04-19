using System.ComponentModel.DataAnnotations;

namespace Models;
public class Products
{
    public string Name = "";
    public double Cost = 0.00f;

    public string name
    {
        get => name;
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ValidationException("Invalid input. Please try again.");
            name = value;
        }
    }
    public double cost
    {
        get => cost;
        set
        {
            if (value <= 0.00)
                throw new ValidationException("Invalid input. Please try again.");
            cost = value;
        }
    }
    public string ToString()
    {
        return $"[{cost}]:\t{Name}";
    }
}