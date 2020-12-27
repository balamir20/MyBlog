using MyBlog.Core.BaseModels.Repositories;
using MyBlog.Data.Model.Infrastructure.Categories.Category.Entity;
using System.Threading.Tasks;

namespace MyBlog.Data.Repository.Infrastructure.Categories.Category
{
    public interface ICategoryRepository : IRepository<CategoryEntity>
    {
        Task<CategoryEntity> GetWithArticlesByIdAsync(int categoryId);
    }
}
