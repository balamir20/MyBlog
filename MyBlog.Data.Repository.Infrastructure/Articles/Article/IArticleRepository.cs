using MyBlog.Core.BaseModels.Repositories;
using MyBlog.Data.Model.Infrastructure.Articles.Article.Entity;
using System.Threading.Tasks;

namespace MyBlog.Data.Repository.Infrastructure.Articles.Article
{
    public interface IArticleRepository : IRepository<ArticleEntity>
    {
        Task<ArticleEntity> GetWithCategoryByIdAsync(int productId);
    }
}