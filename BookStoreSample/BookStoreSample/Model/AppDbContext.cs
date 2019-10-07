using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Title = "History"
            });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 2,
                Title = "Art"
            });


            modelBuilder.Entity<Book>().HasData(new Book()
            {
                Id = 1,
                Title = "Egypt",
                Price = 100,
                CoverUrl = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/4/8/487333.jpg?1",
                CategoryId = 1

            });
            modelBuilder.Entity<Book>().HasData(new Book()
            {
                Id = 2,
                Title = "Mada'in Saleh",
                Price = 200,
                CoverUrl = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/3/5/352925.jpg?1",
                CategoryId = 1

            });
            modelBuilder.Entity<Book>().HasData(new Book()
            {
                Id = 3,
                Title = "Sons of Sindbad",
                Price = 300,
                CoverUrl = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/4/8/480520.jpg?1",
                CategoryId = 1

            });
            modelBuilder.Entity<Book>().HasData(new Book()
            {
                Id = 4,
                Title = "reSurface - Images of Women in The Rock Art of Saudi Arabia",
                Price = 500,
                CoverUrl = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/4/7/473228.jpg?1",
                CategoryId = 1

            });


            modelBuilder.Entity<Book>().HasData(new Book()
            {
                Id = 5,
                Title = "Window Treatments for Every Room (Better Homes and Gardens)",
                Price = 500,
                CoverUrl = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/2/8/283208.jpg?1",
                CategoryId = 2

            });

            modelBuilder.Entity<Book>().HasData(new Book()
            {
                Id = 6,
                Title = "Cast-Iron Architecture in America",
                Price = 800,
                CoverUrl = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/1/3/134547.jpg?1",
                CategoryId = 2

            });



        }
        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
