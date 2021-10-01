using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class TrainerExperience
    {
        public int ExperienceId { get; set; }
        public int? TrainerId { get; set; }
        public string ExperienceTechnology { get; set; }
        public int? ExperienceDuration { get; set; }
        public string ExperiencePosition { get; set; }
        public string ExperienceLocation { get; set; }
    }
}
