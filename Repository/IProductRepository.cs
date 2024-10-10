using BrickStoreBackend.Models;

namespace BrickStoreBackend.Repository;

public interface IProductRepository
{
    IEnumerable<BrickProduct> GetAll();
    BrickProduct GetById(int id);
    void Add(BrickProduct product);
    void Update(BrickProduct product);
    void Delete(int id);
}