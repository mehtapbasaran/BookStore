using BookStore.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.IMainRepository
{
   public interface IOrderDetailRepository: IRepository<OrderDetails>
    {
        void Update(OrderDetails orderDetails);
    }
}
