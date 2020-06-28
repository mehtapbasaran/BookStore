using BookStore.Data;
using BookStore.DataAccess.IMainRepository;
using BookStore.Models.DbModels;

namespace BookStore.DataAccess.MainRepository
{
    public class OrderDetailRepository : Repository<OrderDetails>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetails orderDetails)
        {
            _db.Update(orderDetails);
        }
    }
}
