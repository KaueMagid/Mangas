using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mangas.Models;
using Mangas.Data;
using Microsoft.EntityFrameworkCore;

namespace Mangas.Services
{
    public class TitleService
    {
        private readonly MangasContext _context;

        public TitleService(MangasContext context)
        {
            _context = context;
        }

        public async Task<List<Title>> FindAllAsync()
        {
            return await _context.Title.ToListAsync();
        }

        public async Task<Title> FindByIdAsync(int id)
        {
            return await _context.Title.Include(obj => obj.Company).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task InsertAsync(Title title)
        {
            await _context.AddAsync(title);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(Title title)
        {
            _context.Remove(title);
            await _context.SaveChangesAsync();
        }

        //Create Update later
    }
}
