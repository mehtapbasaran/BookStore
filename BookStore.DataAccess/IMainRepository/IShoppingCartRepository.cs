using BookStore.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.IMainRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart shoppingCart);
    }
}
