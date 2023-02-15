using MemberApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MemberApp.Data
{
    public class MemberAppDbContext : DbContext
    {
        public MemberAppDbContext(DbContextOptions<MemberAppDbContext> options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
