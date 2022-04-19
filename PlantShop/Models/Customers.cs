using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models;
public class Customers
{
    public string Username
    {
        get => Username;
        set
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new ValidationException("Invalid input please try again.");
        }
    }
    public string Password
    {
        get => Password;
        set
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new ValidationException("Invalid input please try again.");
        }
    }
}