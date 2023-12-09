using Microsoft.EntityFrameworkCore;
using SocialAPI.TEntities;

namespace SocialAPI.TData
{
    public class TDataContext : DbContext
    {
        public TDataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
    }
}
