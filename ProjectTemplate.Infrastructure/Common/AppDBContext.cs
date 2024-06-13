using ProjectTemplate.Domain;
using Microsoft.EntityFrameworkCore;

namespace ProjectTemplate.Infrastructure.Common
{
    public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }
            public DbSet<RoleModel> RoleModel { get; set; }
        }
    }
