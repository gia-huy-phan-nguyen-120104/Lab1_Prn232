using BusinessObjects.Models;
using DataAccessObjects;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts() => ProductDAO.GetProducts();

        public Product GetProductById(int id) => ProductDAO.GetProductById(id);

        public void SaveProduct(Product product) => ProductDAO.SaveProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.UpdateProduct(product);

        public void DeleteProduct(Product product) => ProductDAO.DeleteProduct(product);
    }
}
