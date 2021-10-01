using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldTrainer.Models
{
    public class Mapper
    {
        public static WorldTrainer.Models.TrainerModel Map1(Data.Entities.Trainer t)
        {
            return new WorldTrainer.Models.TrainerModel()
            {
                TrainerId = t.TrainerId,
                TrainerName = t.TrainerName,
                TrainerEmail = t.TrainerEmail,
                TrainerPhone = t.TrainerPhone,
                TrainerAddress = t.TrainerAddress,
                TrainerPassword = t.TrainerPassword,
                Gender = t.Gender,
            };
        }
    

        public static Data.Entities.Trainer Map2(WorldTrainer.Models.TrainerModel t)
        {
            return new Data.Entities.Trainer()
            {
                TrainerId = t.TrainerId,
                TrainerName = t.TrainerName,
                TrainerEmail = t.TrainerEmail,
                TrainerPhone = t.TrainerPhone,
                TrainerAddress = t.TrainerAddress,
                TrainerPassword = t.TrainerPassword,
                Gender = t.Gender
            };
        }
        public static Data.Entities.Trainer Map13(WorldTrainer.Models.TrainerModel t)
        {
            return new Data.Entities.Trainer()
            {
                TrainerName = t.TrainerName,
                TrainerEmail = t.TrainerEmail,
                TrainerPhone = t.TrainerPhone,
                TrainerAddress = t.TrainerAddress,
                TrainerPassword = t.TrainerPassword,
                Gender = t.Gender
            };
        }

        public static WorldTrainer.Models.ExperinceModel Map3(Data.Entities.TrainerExperience t)
        {
            return new WorldTrainer.Models.ExperinceModel()
            {
                ExperienceId = t.ExperienceId,
                TrainerId = t.TrainerId,
                ExperienceTechnology = t.ExperienceTechnology,
                ExperienceDuration = t.ExperienceDuration,
                ExperiencePosition = t.ExperiencePosition,
                ExperienceLocation = t.ExperienceLocation,

            };
        }
        public static Data.Entities.TrainerExperience Map4(WorldTrainer.Models.ExperinceModel t)
        {
            return new Data.Entities.TrainerExperience()
            {
                ExperienceId = t.ExperienceId,
                TrainerId = t.TrainerId,
                ExperienceTechnology = t.ExperienceTechnology,
                ExperienceDuration = t.ExperienceDuration,
                ExperiencePosition = t.ExperiencePosition,
                ExperienceLocation = t.ExperienceLocation
            };
        }
        public static Data.Entities.TrainerExperience Map9(WorldTrainer.Models.ExperinceModel t)
        {
            return new Data.Entities.TrainerExperience()
            {
               
                TrainerId = t.TrainerId,
                ExperienceTechnology = t.ExperienceTechnology,
                ExperienceDuration = t.ExperienceDuration,
                ExperiencePosition = t.ExperiencePosition,
                ExperienceLocation = t.ExperienceLocation
            };
        }

        public static WorldTrainer.Models.QualifationModel Map5(Data.Entities.TrainerQualification t)
        {
            return new WorldTrainer.Models.QualifationModel()
            {
                QualificationId = t.QualificationId,
                TrainerId = t.TrainerId,
                HighSchoolGrade = t.HighSchoolGrade,
                JrcollegeGrade = t.JrcollegeGrade,
                GraduatedIn = t.GraduatedIn,
                ExtraCertifications = t.ExtraCertifications,

            };
        }
        public static Data.Entities.TrainerQualification Map6(WorldTrainer.Models.QualifationModel t)
        { 
            return new Data.Entities.TrainerQualification()
            {
                QualificationId = t.QualificationId,
                TrainerId = t.TrainerId,
                HighSchoolGrade = t.HighSchoolGrade,
                JrcollegeGrade = t.JrcollegeGrade,
                GraduatedIn = t.GraduatedIn,
                ExtraCertifications = t.ExtraCertifications,
            };
        }
        public static Data.Entities.TrainerQualification Map10(WorldTrainer.Models.QualifationModel t)
        {
            return new Data.Entities.TrainerQualification()
            {
               
                TrainerId = t.TrainerId,
                HighSchoolGrade = t.HighSchoolGrade,
                JrcollegeGrade = t.JrcollegeGrade,
                GraduatedIn = t.GraduatedIn,
                ExtraCertifications = t.ExtraCertifications,
            };
        }
        public static WorldTrainer.Models.SkillModel Map7(Data.Entities.TechSkill t)
        {
            return new WorldTrainer.Models.SkillModel()
            {
                SkillId = t.SkillId,
                TrainerId = t.TrainerId,
                TechSkill_1 = t.TechSkill_1

            };
        }
        public static Data.Entities.TechSkill Map8(WorldTrainer.Models.SkillModel t)
        {
            return new Data.Entities.TechSkill()
            {
                SkillId = t.SkillId,
                TrainerId = t.TrainerId,
                TechSkill_1 = t.TechSkill_1
            };
        }
        public static Data.Entities.TechSkill Map11(WorldTrainer.Models.SkillModel t)
        {
            return new Data.Entities.TechSkill()
            {
                TrainerId = t.TrainerId,
                TechSkill_1 = t.TechSkill_1
            };
        }
    }
}


