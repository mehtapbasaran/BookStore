using BookStore.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.IMainRepository
{
   public interface ICategoryRepository: IRepository<Category>
    {
        void Update(Category category);
    }
}
