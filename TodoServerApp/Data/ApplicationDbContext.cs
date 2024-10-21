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
                new() { Id = 1, Title="Задача 1", Description="Приготовить покушать", CreatedDate=DateTime.Now},
                new() { Id = 2, Title="Задача 2", Description="Поизучать английский язык", CreatedDate=DateTime.Now},
                new() { Id = 3, Title="Задача 3", Description="Сдать на права", CreatedDate=DateTime.Now},
                new() { Id = 4, Title="Задача 4", Description="Сходить в зал и в бассейн", CreatedDate=DateTime.Now},
                new() { Id = 5, Title="Задача 5", Description="Апнуть 4k elo", CreatedDate=DateTime.Now},
                new() { Id = 6, Title="Задача 6", Description="Выучить JavaScript", CreatedDate=DateTime.Now},
            ]);
        }
    }
}
