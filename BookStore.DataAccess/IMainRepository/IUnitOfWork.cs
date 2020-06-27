using System;


namespace BookStore.DataAccess.IMainRepository
{
   public interface IUnitOfWork: IDisposable
    {
        ICategoryRepository Category { get; }
        ICompanyRepository Company { get; }

        IProductRepository Product { get; }

        ICoverTypeRepository CoverType { get; }
        IApplicationUserRepository ApplicationUser { get; }

        ISPCallRepository sp_call { get; }


        void Save();
    }
}
