using BrickStoreBackend.Models;
using BrickStoreBackend.Repository;

namespace BrickStoreBackend.Service;

public interface IProductService
{
    bool CreateProduct(BrickProduct product);
    IEnumerable<BrickProduct> GetProducts();
    BrickProduct? GetProductById(int productId);
    BrickProduct GetProductByName(string productName);
    bool UpdateProduct(BrickProduct? product);
    bool DeleteProduct(int productId);
}

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public bool CreateProduct(BrickProduct product)
    {
        return _productRepository.Create(product);
    }

    public IEnumerable<BrickProduct> GetProducts()
    {
        return _productRepository.GetAll();
    }

    public BrickProduct? GetProductById(int productId)
    {
        return _productRepository.GetById(productId);
    }

    public BrickProduct GetProductByName(string productName)
    {
        return _productRepository.GetByName(productName);
    }

    public bool UpdateProduct(BrickProduct? product)
    {
        return _productRepository.Update(product);
    }

    public bool DeleteProduct(int productId)
    {
      return  _productRepository.Delete(productId);
    }
}