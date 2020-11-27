namespace eShop.UseCases.ViewProductScreen
{
    public interface IAddProductToCartUseCase
    {
        void ExecuteAsync(int productId);
    }
}