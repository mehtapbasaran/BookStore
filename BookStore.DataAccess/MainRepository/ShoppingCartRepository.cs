using BookStore.Data;
using BookStore.DataAccess.IMainRepository;
using BookStore.Models.DbModels;
using System.Linq;

namespace BookStore.DataAccess.MainRepository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart shoppingCart)
        {
            _db.Update(shoppingCart);
        }
    }
}
