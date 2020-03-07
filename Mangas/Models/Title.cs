using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangas.Models
{
    public class Title
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Volume> Volumes { get; set; }
        public int IdCompany { get; set; }
        public Company Company { get; set; }

    }
}
