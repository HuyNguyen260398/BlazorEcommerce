using BlazorEcommerce.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorEcommerce.UseCases.PluginInterfaces.DataStore
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(string filter);
        Product GetProduct(int id);
    }
}
