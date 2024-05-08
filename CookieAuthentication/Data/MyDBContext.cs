using CookieAuthentication.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookieAuthentication.Data
{
    public class MyDBContext :DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext>options):base (options) { }
        public DbSet<User> Users { get; set; } = default;
    }
}
