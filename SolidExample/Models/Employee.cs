using SolidExample.Interfaces;

namespace SolidExample.Models;

public class Employee : IEmployee
{
    public Guid Id { get; set; }
    public string Firstname { get; set; } = "";
    public string Lastname { get; set; } = "";
    public string Email { get; set; } = "";

    public string GetFullname()
    {
        return $"{Firstname} {Lastname}";
    }
}