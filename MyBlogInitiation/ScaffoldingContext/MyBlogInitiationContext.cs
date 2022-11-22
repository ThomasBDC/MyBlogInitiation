using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBlogInitiation.Models;

namespace MyBlogInitiation.Data
{
    public class MyBlogInitiationContext : DbContext
    {
        public MyBlogInitiationContext (DbContextOptions<MyBlogInitiationContext> options)
            : base(options)
        {
        }

        public DbSet<MyBlogInitiation.Models.ArticleModel> Articles { get; set; } = default!;
    }
}
