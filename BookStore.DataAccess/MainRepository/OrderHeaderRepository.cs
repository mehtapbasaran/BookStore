using BookStore.Data;
using BookStore.DataAccess.IMainRepository;
using BookStore.Models.DbModels;
using System.Linq;

namespace BookStore.DataAccess.MainRepository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader orderHeader)
        {
            _db.Update(orderHeader);
        }
    }
}
