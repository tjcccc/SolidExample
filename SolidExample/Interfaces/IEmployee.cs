namespace SolidExample.Interfaces;

public interface IEmployee
{
    public Guid Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }

    public string GetFullname();
}