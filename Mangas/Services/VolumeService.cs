using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mangas.Data;
using Mangas.Models;
using Microsoft.EntityFrameworkCore;

namespace Mangas.Services
{
    public class VolumeService
    {
        private readonly MangasContext _context;

        public VolumeService(MangasContext context)
        {
            _context = context;
        }

        public async Task<List<IGrouping<Title,Volume>>> FindAllTitle()
        {
            var result = from obj in _context.Volume select obj;
            return await result
                .Include(x => x.Title)
                .Include(x => x.Title.Company)
                .OrderBy(x => x.Title.Name)
                .GroupBy(x => x.Title)
                .ToListAsync();
        }
    }
}
