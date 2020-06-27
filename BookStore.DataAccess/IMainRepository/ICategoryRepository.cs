using BookStore.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.IMainRepository
{
   public interface ICompanyRepository: IRepository<Company>
    {
        void Update(Company company);
    }
}
