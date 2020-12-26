using MyBlog.Core.BaseModels.Models;

namespace MyBlog.Data.Model.Infrastructure
{
    /// <summary>
    /// Projeme özel her classta olması gereken property olursa buraya ekliyorum
    /// </summary>
    public abstract class BlogBaseEntity : BaseEntity, IBlogEntity
    {
    }
}
