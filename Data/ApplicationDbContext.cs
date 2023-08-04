using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenVanSon_02.Models;
namespace NguyenVanSon_02.Data;
{
        public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenVanSonDb> NguyenVanSonDb { get; set; } = default!;
    }
}

