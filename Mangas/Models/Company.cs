using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mangas.Models
{
    public class Company
    {
        public int Id { get; set; }

        public List<Title> Titles { get; set; } = new List<Title>();

        [Required(ErrorMessage = "{0} required")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1} caracters")]
        public string Name { get; set; }

        [DataType(DataType.Url)]
        public string SiteAdress { get; set; }

        public Company(){}

        public Company(int id, string name, string siteAdress)
        {
            Id = id;
            Name = name;
            SiteAdress = siteAdress;
        }
    }
}
