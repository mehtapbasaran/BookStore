using BookStore.Data;
using BookStore.DataAccess.IMainRepository;
using BookStore.Models.DbModels;
using System.Linq;

namespace BookStore.DataAccess.MainRepository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }
    }
}
