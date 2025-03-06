using AutoRepairJsonWersion.Components.Models;

namespace AutoRepairJsonWersion.Components.Services;

public class LoginProvider(ClientProvider clientProvider)
{
    private Client? _currentUser;
    
    
    public void Login(string login, string password)
    {
        var item = clientProvider.GetUserByEmail(login);
        if(item is null) throw new Exception("User not found");
        if(item.ClientCredentials.Login != login && item.ClientCredentials.Password != password) throw new Exception("Wrong login or password");
        _currentUser = item;
    }
    public void Logout() 
    {
        _currentUser = null;
    }
    
}