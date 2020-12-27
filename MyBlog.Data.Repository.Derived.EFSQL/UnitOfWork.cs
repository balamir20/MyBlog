using MyBlog.Data.Repository.Derived.EFSQL.Repositories.Articles;
using MyBlog.Data.Repository.Derived.EFSQL.Repositories.Categories;
using MyBlog.Data.Repository.Infrastructure;
using MyBlog.Data.Repository.Infrastructure.Articles.Article;
using MyBlog.Data.Repository.Infrastructure.Categories.Category;
using System.Threading.Tasks;

namespace MyBlog.Data.Repository.Derived.EFSQL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ArticleRepository _articleRepository;
        private CategoryRepository _categoryRepository;

        public ICategoryRepository Category => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
        public IArticleRepository Article => _articleRepository = _articleRepository ?? new ArticleRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
