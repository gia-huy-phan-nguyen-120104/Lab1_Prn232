using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();

            try
            {
                using var context = new MyStoreContext();
                listProducts = context.Products.Include(c => c.Category).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listProducts;
        }

        public static Product GetProductById(int productId)
        {
            Product product = null;

            try
            {
                using var context = new MyStoreContext();
                product = context.Products.SingleOrDefault(x => x.ProductId == productId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return product;
        }

        public static void SaveProduct(Product p)
        {
            try
            {
                using var context = new MyStoreContext();
                p.Category = null; // prevent EF from cascade-tracking navigation property
                context.Products.Add(p);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateProduct(Product p)
        {
            try
            {
                using var context = new MyStoreContext();
                p.Category = null; // prevent EF from cascade-tracking navigation property
                context.Entry<Product>(p).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteProduct(Product p)
        {
            try
            {
                using var context = new MyStoreContext();

                var product = context.Products.SingleOrDefault(c => c.ProductId == p.ProductId);

                context.Products.Remove(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}