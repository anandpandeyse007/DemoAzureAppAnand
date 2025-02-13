using mvc_web_azure_app_anand.Data;
using mvc_web_azure_app_anand.Models;

namespace mvc_web_azure_app_anand.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int? id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            
            return product == null ? null : product;
        }

        public string CreateProduct(Product product) 
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();

                return "success";
            }
            catch (Exception ex) {

                return ex.Message;
            
            }
                    
        }
        public string UpdateProduct(Product product)
        {
            try
            {
                var _product = _context.Products.Find(product.Id);
                if (_product != null)
                {
                    _product.Name = product.Name;
                    _product.Price = product.Price;
                    _context.Products.Update(_product);
                    _context.SaveChanges();                   
                }
                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
                       
        }

        public Product DeleteProduct(int? id)
        {
            Product? product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();

                return product;
            }
            else
            {
                return null;
            }
        }       
    }
}
