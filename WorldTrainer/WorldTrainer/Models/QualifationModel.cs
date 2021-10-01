using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldTrainer.Models
{
    public class QualifationModel
    {
        [Microsoft.AspNetCore.Mvc.HiddenInput]
        public int QualificationId { get; set; }
        [Microsoft.AspNetCore.Mvc.HiddenInput]
        public int? TrainerId { get; set; }
        public string HighSchoolGrade { get; set; }
        public string JrcollegeGrade { get; set; }
        public string GraduatedIn { get; set; }
        public string ExtraCertifications { get; set; }
    }
}
