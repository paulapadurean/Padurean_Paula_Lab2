using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Padurean_Paula_Lab2.Models;

namespace Padurean_Paula_Lab2.Data
{
    public class Padurean_Paula_Lab2Context : DbContext
    {
        public Padurean_Paula_Lab2Context (DbContextOptions<Padurean_Paula_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Padurean_Paula_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Padurean_Paula_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Padurean_Paula_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
