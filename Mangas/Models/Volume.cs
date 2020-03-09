using Mangas.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangas.Models
{
    public class Volume
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int IdTitle { get; set; }
        public Title Title { get; set; }
        public VolumeStatus VolumeStatus { get; set;}

        public Volume(){}

        public Volume(int id, int number, int idTitle, Title title, VolumeStatus volumeStatus)
        {
            Id = id;
            Number = number;
            IdTitle = idTitle;
            Title = title;
            VolumeStatus = volumeStatus;
        }
    }
}
