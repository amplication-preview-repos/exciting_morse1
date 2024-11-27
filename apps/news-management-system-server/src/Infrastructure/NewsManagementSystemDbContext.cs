using Microsoft.EntityFrameworkCore;
using NewsManagementSystem.Infrastructure.Models;

namespace NewsManagementSystem.Infrastructure;

public class NewsManagementSystemDbContext : DbContext
{
    public NewsManagementSystemDbContext(DbContextOptions<NewsManagementSystemDbContext> options)
        : base(options) { }

    public DbSet<NewsDbModel> NewsItems { get; set; }

    public DbSet<UserTypeDbModel> UserTypes { get; set; }

    public DbSet<AdminDbModel> Admins { get; set; }

    public DbSet<UserDbModel> Users { get; set; }
}
