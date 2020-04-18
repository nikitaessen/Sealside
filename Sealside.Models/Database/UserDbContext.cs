using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Sealside.Models.Database
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public List<User> GetUsers() => Users.Local.ToList();
    }
}
