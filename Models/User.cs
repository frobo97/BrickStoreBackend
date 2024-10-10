namespace BrickStoreBackend.Models;

public class User(string firstName, string lastName, string email, string password)
{
    private int Id { get; set; }
    private string FirstName { get; set; } = firstName;
    private string LastName { get; set; } = lastName;
    private string Email { get; set; } = email;
    private string Password { get; set; } = password;
}