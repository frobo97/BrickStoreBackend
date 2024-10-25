using BrickStoreBackend.Data;
using BrickStoreBackend.Models;

namespace BrickStoreBackend.Repository;

public interface IUserRepository
{
    IEnumerable<User?> GetAll();
    User? GetById(int id);
    User? GetByEmail(string email);
    bool Create(User user);
    bool Update(User? user);
    void Delete(int id);
}

public class UserRepository : IUserRepository
{
    private readonly DbContextSqLite _context;

    public UserRepository(DbContextSqLite context)
    {
        _context = context;
    }

    public IEnumerable<User?> GetAll()
    {
        return _context.Users.ToList();
    }

    public User? GetById(int id)
    {
        return _context.Users.Find(id);
    }

    public User? GetByEmail(string email)
    {
        return _context.Users.Find(email);
    }

    public bool Create(User user)
    {
        try
        {
            _context.Users.Add(user);
            var result = _context.SaveChanges();
            return result > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return false;
    }

    public bool Update(User? user)
    {
        try
        {
            if (user != null)
            {
                _context.Users.Update(user);
                var result = _context.SaveChanges();
                return result > 0;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return false;
    }

    public void Delete(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null) return;
        _context.Users.Remove(user);
        _context.SaveChanges();
    }
}