using BrickStoreBackend.Data;
using BrickStoreBackend.Models;

namespace BrickStoreBackend.Repository;

public interface IProductRepository
{
    List<BrickProduct?> GetAll();
    BrickProduct? GetById(int id);
    BrickProduct? GetByName(string name);
    bool Create(BrickProduct? product);
    bool Update(BrickProduct? product);
    bool Delete(int id);
}

public class ProductRepository : IProductRepository
{
    private readonly DbContextSqLite _context;

    public ProductRepository(DbContextSqLite context)
    {
        _context = context;
    }

    public bool Create(BrickProduct? product)
    {
        try
        {
            _context.BrickProducts.Add(product);
            var result = _context.SaveChanges();
            return result > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public List<BrickProduct?> GetAll()
    {
        return _context.BrickProducts.ToList();
    }

    public BrickProduct? GetById(int id)
    {
        return _context.BrickProducts.Find(id);
    }

    public BrickProduct? GetByName(string name)
    {
        return _context.BrickProducts.Find(name);
    }

    public bool Update(BrickProduct? product)
    {
        try
        {
            if (product != null)
            {
                var productToUpdate = _context.BrickProducts.Find(product.Id);
                _context.BrickProducts.Update(productToUpdate);
                var result = _context.SaveChanges();
                return result > 0;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return false;
    }

    public bool Delete(int id)
    {
        try
        {
            if (id > -1 & id != null)
            {
                var productToDelete = _context.BrickProducts.Find(id);
                _context.BrickProducts.Remove(productToDelete);
                var result = _context.SaveChanges();
                return result > 0;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return false;
    }
}