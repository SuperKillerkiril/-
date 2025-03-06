namespace AutoRepairJsonWersion.Components.Models;

public class Client
{
    public string Name { get; set; }
    public string LastName { get; set; }
    //public Role Role { get; set; } //поле, "Role" которое берется из enum UserRole
    public Credentials ClientCredentials { get; set; }

    public Client(string name, string lastName, Role role, Credentials clientCredentials)
    {
        Name = name;
        LastName = lastName;
       // Role = role;
        ClientCredentials = clientCredentials;
    }
}