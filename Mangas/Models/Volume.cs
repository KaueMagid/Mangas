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
        public int TitleId { get; set; }
        public Title Title { get; set; }
        public VolumeStatus VolumeStatus { get; set;}
        public string Image { get; set; }

        public Volume(){}

        public Volume(int id, int number, int titleId, Title title, VolumeStatus volumeStatus)
        {
            Id = id;
            Number = number;
            TitleId = titleId;
            Title = title;
            VolumeStatus = volumeStatus;
            Image = Title.Name + Number;
        }
    }
}
