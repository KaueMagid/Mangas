﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mangas.Models.Enums;

namespace Mangas.Models
{
    public class Title
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCompany { get; set; }
        public Company Company { get; set; }
        public TitleStatus TitleStatus { get; set; }
        public List<Volume> Volumes { get; set; } = new List<Volume>();
        public ColectionStatus ColectionStatus { get; set; }


        public bool GetVolumesStatus()
        {
            int possessedVolumes = Volumes.Where(x => x.VolumeStatus == VolumeStatus.possess).Count();
            if (possessedVolumes == Volumes.Count())
            {
                return true;
            }
            return false;
        }
        public void GetColectionStatus()
        {
            if (!GetVolumesStatus())
            {
                ColectionStatus = ColectionStatus.outdated;
            }
            else if (TitleStatus == TitleStatus.finished)
            {
                ColectionStatus = ColectionStatus.complete;
            }
            else
            {
                ColectionStatus = ColectionStatus.updated;
            }
        }
    }
}
