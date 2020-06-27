using BookStore.Data;
using BookStore.DataAccess.IMainRepository;
using BookStore.Models.DbModels;
using System.Linq;

namespace BookStore.DataAccess.MainRepository
{
   public class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var data = _db.Categories.FirstOrDefault(x => x.Id == category.Id);

            if (data != null)
            {
                data.CategoryName = category.CategoryName;
            }

            _db.SaveChanges();
        }
    }
}
