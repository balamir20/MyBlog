using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Model.Infrastructure.Articles.Article.Entity;
using MyBlog.Data.Repository.Infrastructure.Articles.Article;
using System.Threading.Tasks;

namespace MyBlog.Data.Repository.Derived.EFSQL.Repositories.Articles
{
    public class ArticleRepository : BaseRepository<ArticleEntity>, IArticleRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public ArticleRepository(DbContext context) : base(context)
        {
        }

        public async Task<ArticleEntity> GetWithCategoryByIdAsync(int articleId)
        {
            return await _appDbContext.Articles.Include(m => m.Category).SingleOrDefaultAsync(x => x.Id == articleId);
        }
    }
}
