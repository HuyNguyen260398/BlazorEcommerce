using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper.Helpers;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.DataStore.SQL.Dapper
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataAccess dataAccess;

        public ProductRepository(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Product GetProduct(int id)
        {
            return dataAccess.QuerySingle<Product, dynamic>("SELECT * FROM Product WHERE Id = @ProductId", new { ProductId = id });
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            List<Product> list;
            if (string.IsNullOrWhiteSpace(filter))
                list = dataAccess.Query<Product, dynamic>("SELECT * FROM Product", new { });
            else
                list = dataAccess.Query<Product, dynamic>("SELECT * FROM Product WHERE Name like '%' + @Filter + '%'", new { Filter = filter });

            return list.AsEnumerable();
        }
    }
}
