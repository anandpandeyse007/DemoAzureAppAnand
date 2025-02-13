using mvc_web_azure_app_anand.Models;

namespace mvc_web_azure_app_anand.Repository
{
    public interface IProductRepository
    {
        string CreateProduct(Product product);
        List<Product> GetProducts();
        Product GetProductById(int? id);
        string UpdateProduct(Product product);
        Product DeleteProduct(int?  id);
    }
}
