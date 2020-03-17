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

        public DbSet<Company> Company { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<Volume> Volume { get; set; }
    }
}
