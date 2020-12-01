using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.AdminPortal.OutStandingOrdersScreen
{
    public interface IViewOutStandingOrdersUseCase
    {
        IEnumerable<Order> Execute();
    }
}