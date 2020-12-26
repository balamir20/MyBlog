using MyBlog.Core.BaseModels.Interfaces;
using System;

namespace MyBlog.Core.BaseModels.Models
{
    /// <summary>
    /// Standart her dto'da olması gereken propertyler
    /// </summary>
    public class BaseDto : IModel
    {
        public int Id { get; set; }
        public Guid UniqId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DeletedTime { get; set; }
        public bool IsDeleted { get; set; }
        public int Position { get; set; }
    }
}
