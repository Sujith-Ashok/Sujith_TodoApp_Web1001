using System;
using Microsoft.EntityFrameworkCore;
using SujithAshok_ToDoApp.Models;

namespace SujithAshok_ToDoApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
