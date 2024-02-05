using ECommerce.Basket.Dtos;

namespace ECommerce.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasketTotalAsync(string UserID);
        Task SaveBasket(BasketTotalDto basketTotalDto);
        Task DeleteBasket(string UserID);
    }
}
