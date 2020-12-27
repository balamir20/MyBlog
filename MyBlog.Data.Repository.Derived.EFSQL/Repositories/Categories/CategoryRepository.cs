using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Model.Infrastructure.Categories.Category.Entity;
using MyBlog.Data.Repository.Infrastructure.Categories.Category;
using System.Threading.Tasks;

namespace MyBlog.Data.Repository.Derived.EFSQL.Repositories.Categories
{
    public class CategoryRepository : BaseRepository<CategoryEntity>, ICategoryRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public CategoryRepository(DbContext context) : base(context)
        {
        }

        public async Task<CategoryEntity> GetWithArticlesByIdAsync(int categoryId)
        {
            return await _appDbContext.Categories.Include(m => m.Articles).SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}
