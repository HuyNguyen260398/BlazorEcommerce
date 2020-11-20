using BlazorEcommerce.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorEcommerce.UseCases.SearchProductScreen
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}
