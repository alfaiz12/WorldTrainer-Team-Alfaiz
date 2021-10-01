using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldTrainer.Models
{
    public class SkillModel
    {
        [Microsoft.AspNetCore.Mvc.HiddenInput]
        public int SkillId { get; set; }
        [Microsoft.AspNetCore.Mvc.HiddenInput]
        public int? TrainerId { get; set; }
        public string TechSkill_1 { get; set; }
    }
}
