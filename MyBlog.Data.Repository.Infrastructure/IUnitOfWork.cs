using MyBlog.Data.Repository.Infrastructure.Articles.Article;
using MyBlog.Data.Repository.Infrastructure.Categories.Category;
using System.Threading.Tasks;

namespace MyBlog.Data.Repository.Infrastructure
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IArticleRepository Article { get; }
        Task CommitAsync();
        void Commit();
    }
}
