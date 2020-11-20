using BlazorEcommerce.CoreBusiness.Models;
using BlazorEcommerce.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorEcommerce.UseCases.SearchProductScreen
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepository productRepository;

        public ViewProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Product Execute(int id)
        {
            return productRepository.GetProduct(id);
        }
    }
}
