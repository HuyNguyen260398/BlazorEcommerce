using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProductUseCase : ISearchProductUseCase
    {
        private readonly IProductRepository productRepositoty;

        public SearchProductUseCase(IProductRepository productRepository)
        {
            this.productRepositoty = productRepository;
        }
        public IEnumerable<Product> Execute(string filter = null)
        {
            return productRepositoty.GetProducts(filter);
        }
    }
}
