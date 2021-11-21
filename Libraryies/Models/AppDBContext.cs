using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libraryies.Models
{
    class AppDBContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-T9I84G9\MSSQLSERVER01;Database=BookLibrary;Trusted_Connection=True;");
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }

        public DbSet<AuthorBook> AuthorBook { get; set; }



    }

}
