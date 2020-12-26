using System;

namespace MyBlog.Core.BaseModels.Interfaces
{
    public interface IModel
    {
        int Id { get; set; }
        Guid UniqId { get; set; }
        DateTime CreateTime { get; set; }
        DateTime? UpdateTime { get; set; }
        bool IsActive { get; set; }
        DateTime? DeletedTime { get; set; }
        bool IsDeleted { get; set; }
        int Position { get; set; }
    }
}
