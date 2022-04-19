using System.ComponentModel.DataAnnotations;
namespace Models;
public class StoreFront
{
    private string city = "";

    public string storelocation
    {
        get => city;
        set
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new ValidationException("Invalid Input. Please try again.");
            city = value;
        }
    }
    // //public override string ToString() 
    // {
    //     return $"[{Id}]: {city}";
    // }
}