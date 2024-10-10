using BrickStoreBackend.Data;
using BrickStoreBackend.Models;

namespace BrickStoreBackend.Repository;

public class ProductRepository(DbContextSqLite context) : IProductRepository
{
    
    private readonly DbContextSqLite _context = context;

    public void Add(BrickProduct product)
    {
        _context.BrickProducts.Add(product);
        _context.SaveChanges();
    }

    public IEnumerable<BrickProduct> GetAll()
    {
        return _context.BrickProducts.ToList();
    }

    public BrickProduct GetById(int id)
    {
        return _context.BrickProducts.Find(id);
    }

    public void Update(BrickProduct product)
    {
        _context.BrickProducts.Update(product);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var product = _context.BrickProducts.Find(id);
        if (product!= null)
        {
            _context.BrickProducts.Remove(product);
            _context.SaveChanges();
        }
    }
}