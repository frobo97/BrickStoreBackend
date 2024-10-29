using BrickStoreBackend.Models;
using BrickStoreBackend.Repository;

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
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IEnumerable<User?> GetAll()
    {
        return _userRepository.GetAll();
    }

    public User? GetUserById(int id)
    {
        return _userRepository.GetById(id);
    }

    public User? GetUserByEmail(string email)
    {
        return _userRepository.GetByEmail(email);
    }

    public bool CreateUser(User user)
    {
        return _userRepository.Create(user);
    }

    public bool UpdateUser(User? user)
    {
        return _userRepository.Update(user);
    }

    public void DeleteUser(int id)
    {
        _userRepository.Delete(id);
    }
}