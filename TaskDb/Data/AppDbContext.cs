using Microsoft.EntityFrameworkCore;
using TaskDb.Models;


namespace TaskDb.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<TaskItem> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TaskItem>().HasData(
            new TaskItem 
            { 
                Id = 1, 
                Title = "Изучить ASP.NET Core", 
                Description = "Пройти базовый курс по ASP.NET Core", 
                IsCompleted = false, 
                Priority = "High", 
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) 
            },
            new TaskItem 
            { 
                Id = 2, 
                Title = "Подключить SQLite через EF Core", 
                Description = "Настроить подключение к базе данных SQLite", 
                IsCompleted = false, 
                Priority = "Normal", 
                CreatedAt = new DateTime(2024, 1, 2, 0, 0, 0, DateTimeKind.Utc) 
            },
            new TaskItem 
            { 
                Id = 3, 
                Title = "Написать README", 
                Description = "Описать проект в файле README.md", 
                IsCompleted = true, 
                Priority = "Low", 
                CreatedAt = new DateTime(2024, 1, 3, 0, 0, 0, DateTimeKind.Utc) 
            }
        );
    }
}

