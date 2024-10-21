using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskItem>().HasData([
                new() { Id = 1, Title="������ 1", Description="����������� ��������", CreatedDate=DateTime.Now},
                new() { Id = 2, Title="������ 2", Description="��������� ���������� ����", CreatedDate=DateTime.Now},
                new() { Id = 3, Title="������ 3", Description="����� �� �����", CreatedDate=DateTime.Now},
                new() { Id = 4, Title="������ 4", Description="������� � ��� � � �������", CreatedDate=DateTime.Now},
                new() { Id = 5, Title="������ 5", Description="������ 4k elo", CreatedDate=DateTime.Now},
                new() { Id = 6, Title="������ 6", Description="������� JavaScript", CreatedDate=DateTime.Now},
            ]);
        }
    }
}
