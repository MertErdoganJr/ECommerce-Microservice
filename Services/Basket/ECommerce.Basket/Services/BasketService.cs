using ECommerce.Basket.Dtos;
using ECommerce.Basket.Settings;

namespace ECommerce.Basket.Services
{
    public class BasketService : IBasketService
    {
        //private readonly RedisSettings _redisSettings;
        public Task DeleteBasket(string UserID)
        {
            throw new NotImplementedException();
        }

        public Task<BasketTotalDto> GetBasketTotalAsync(string UserID)
        {
            throw new NotImplementedException();
        }

        public Task SaveBasket(BasketTotalDto basketTotalDto)
        {
            throw new NotImplementedException();
        }
    }
}
