using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBlogInitiation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogInitiation.Repository.Context
{
    public class DbBlogContext : IdentityDbContext<MyBlogInitiationUser>
    {
        public DbBlogContext(DbContextOptions<DbBlogContext> options)
           : base(options)
        {
        }

        public DbSet<ArticleModel> Articles { get; set; }

    }
}
