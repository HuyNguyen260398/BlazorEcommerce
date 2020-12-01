namespace eShop.UseCases.AdminPortal.OrderDetailScreen
{
    public interface IProcessOrderUseCase
    {
        bool Execute(int orderId, string adminUserName);
    }
}