using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldTrainer.Models
{
    public class ExperinceModel
    {
        [Microsoft.AspNetCore.Mvc.HiddenInput]
        public int ExperienceId { get; set; }
        [Microsoft.AspNetCore.Mvc.HiddenInput]
        public int? TrainerId { get; set; }
        public string ExperienceTechnology { get; set; }
        public int? ExperienceDuration { get; set; }
        public string ExperiencePosition { get; set; }
        public string ExperienceLocation { get; set; }
    }
}
