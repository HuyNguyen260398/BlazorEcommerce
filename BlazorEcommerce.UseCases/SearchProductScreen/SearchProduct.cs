using BlazorEcommerce.CoreBusiness.Models;
using BlazorEcommerce.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorEcommerce.UseCases.SearchProductScreen
{
    public class SearchProduct : ISearchProduct
    {
        private readonly IProductRepository productRepositoty;

        public SearchProduct(IProductRepository productRepository)
        {
            this.productRepositoty = productRepository;
        }
        public IEnumerable<Product> Execute(string filter = null)
        {
            return productRepositoty.GetProducts(filter);
        }
    }
}
