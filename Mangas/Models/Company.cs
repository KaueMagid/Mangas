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

        [Required(ErrorMessage = "{0} required")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1} caracters")]
        public string Name { get; set; }

        [DataType(DataType.Url)]
        public string SiteAdress { get; set; }
    }
}
