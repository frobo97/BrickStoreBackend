using BrickStoreBackend.Models;

namespace BrickStoreBackend.Service;

public interface IUserService
{
    IEnumerable<User?> GetAll();
    User? GetUserById(int id);
    User? GetUserByEmail(string email);
    bool CreateUser(User user);
    bool UpdateUser(User? user);
    void DeleteUser(int id);
}

public class UserService : IUserService

{
    public IEnumerable<User?> GetAll()
    {
        throw new NotImplementedException();
    }

    public User? GetUserById(int id)
    {
        throw new NotImplementedException();
    }

    public User? GetUserByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public bool CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public bool UpdateUser(User? user)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(int id)
    {
        throw new NotImplementedException();
    }
}