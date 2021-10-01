using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Trainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public string TrainerEmail { get; set; }
        public string TrainerPhone { get; set; }
        public string TrainerAddress { get; set; }
        public string TrainerPassword { get; set; }
        public string Gender { get; set; }
    }
}
