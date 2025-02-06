using ECommerceAPI.Application.ViewModels.Baskets;
using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Abstractions.Services
{
    public interface IBasketService
    {
        public Task<List<BasketItem>> GetBasketItemsAsync();
        public Task AddItemToBasketAsync(BasketItemCreate basketItem);
        public Task UpdateQuantityAsync(BasketItemUpdate basketItem);
        public Task RemoveBasketItemAsync(string basketItemId);
    }
}
