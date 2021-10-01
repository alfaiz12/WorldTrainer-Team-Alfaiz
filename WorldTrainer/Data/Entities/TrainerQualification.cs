using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class TrainerQualification
    {
        public int QualificationId { get; set; }
        public int? TrainerId { get; set; }
        public string HighSchoolGrade { get; set; }
        public string JrcollegeGrade { get; set; }
        public string GraduatedIn { get; set; }
        public string ExtraCertifications { get; set; }
    }
}
