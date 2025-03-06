namespace AutoRepairJsonWersion.Components.Models;

public class Credentials
{
        public string Login { get; set; } 
        public string Password { get; set; }
    
        public Credentials(string login, string password)
        {
            Login = login;
            Password = password;
            
        }
        public void СhangePassword(string password)
        {
            Password = password;
        }
}