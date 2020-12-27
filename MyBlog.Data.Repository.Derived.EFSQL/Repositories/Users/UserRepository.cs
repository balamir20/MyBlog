using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Model.Infrastructure.Users.User.Entity;
using MyBlog.Data.Repository.Infrastructure.Users.User;

namespace MyBlog.Data.Repository.Derived.EFSQL.Repositories.Users
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
