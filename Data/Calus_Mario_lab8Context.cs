using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Calus_Mario_lab8.Models;

namespace Calus_Mario_lab8.Data
{
    public class Calus_Mario_lab8Context : DbContext
    {
        public Calus_Mario_lab8Context (DbContextOptions<Calus_Mario_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Calus_Mario_lab8.Models.Book> Book { get; set; }

        public DbSet<Calus_Mario_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Calus_Mario_lab8.Models.BookCategory> BookCategory { get; set; }


    }
}
