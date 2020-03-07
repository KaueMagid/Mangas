using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mangas.Models;

namespace Mangas.Data
{
    public class MangasContext : DbContext
    {
        public MangasContext (DbContextOptions<MangasContext> options)
            : base(options)
        {
        }

        public DbSet<Mangas.Models.Company> Company { get; set; }
    }
}
