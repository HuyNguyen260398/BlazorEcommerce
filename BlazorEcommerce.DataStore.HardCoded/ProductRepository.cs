using BlazorEcommerce.CoreBusiness.Models;
using BlazorEcommerce.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BlazorEcommerce.DataStore.HardCoded
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Brand = "Lenovo",
                    Name = "Thinkpad X1 Carbon Gen 8",
                    Price = 949.99,
                    ImageLink = "https://www.lenovo.com/medias/lenovo-laptop-thinkpad-x1-carbon-gen8-variant-thumbnail.png?context=bWFzdGVyfHJvb3R8NDU0NTR8aW1hZ2UvcG5nfGg0Mi9oZjYvMTA4ODMyNjA2NzgxNzQucG5nfDc1NjdlMjA1NDgyYThlNmMxYjRlOWQ5Y2E0NGVkY2FlNWMyZjgxODE0NzAwMDlmY2E4NTIzZmZhYzA3Y2EyNWU",
                    Description = "New"
                },
                new Product
                {
                    Id = 2,
                    Brand = "Lenovo",
                    Name = "Thinkpad X1 Nano Gen 7",
                    Price = 949.99,
                    ImageLink = "https://www.lenovo.com/medias/lenovo-laptop-thinkpad-x1-carbon-gen8-variant-thumbnail.png?context=bWFzdGVyfHJvb3R8NDU0NTR8aW1hZ2UvcG5nfGg0Mi9oZjYvMTA4ODMyNjA2NzgxNzQucG5nfDc1NjdlMjA1NDgyYThlNmMxYjRlOWQ5Y2E0NGVkY2FlNWMyZjgxODE0NzAwMDlmY2E4NTIzZmZhYzA3Y2EyNWU",
                    Description = "New"
                },
                new Product
                {
                    Id = 3,
                    Brand = "Lenovo",
                    Name = "Thinkpad X1 Extreme Gen 6",
                    Price = 949.99,
                    ImageLink = "https://www.lenovo.com/medias/lenovo-laptop-thinkpad-x1-carbon-gen8-variant-thumbnail.png?context=bWFzdGVyfHJvb3R8NDU0NTR8aW1hZ2UvcG5nfGg0Mi9oZjYvMTA4ODMyNjA2NzgxNzQucG5nfDc1NjdlMjA1NDgyYThlNmMxYjRlOWQ5Y2E0NGVkY2FlNWMyZjgxODE0NzAwMDlmY2E4NTIzZmZhYzA3Y2EyNWU",
                    Description = "New"
                },
                new Product
                {
                    Id = 4,
                    Brand = "Lenovo",
                    Name = "Thinkpad X1 Gen 5",
                    Price = 949.99,
                    ImageLink = "https://www.lenovo.com/medias/lenovo-laptop-thinkpad-x1-carbon-gen8-variant-thumbnail.png?context=bWFzdGVyfHJvb3R8NDU0NTR8aW1hZ2UvcG5nfGg0Mi9oZjYvMTA4ODMyNjA2NzgxNzQucG5nfDc1NjdlMjA1NDgyYThlNmMxYjRlOWQ5Y2E0NGVkY2FlNWMyZjgxODE0NzAwMDlmY2E4NTIzZmZhYzA3Y2EyNWU",
                    Description = "New"
                }
            };
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return products;

            return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }
    }
}
