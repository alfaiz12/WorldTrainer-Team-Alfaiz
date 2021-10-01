using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Repository : IRepository
    {
        private readonly WorldTrainersContext db;
        public Repository(WorldTrainersContext worldTrainersContext)
        {
            db = worldTrainersContext;
        }

        public void AddExp(TrainerExperience t)
        {
            db.TrainerExperiences.Add(t);
            db.SaveChanges();
        }

        public void AddQua(TrainerQualification t)
        {
            db.TrainerQualifications.Add(t);
            db.SaveChanges();
        }

        public void AddSkill(TechSkill t)
        {
            db.TechSkills.Add(t);
            db.SaveChanges();
        }

        public void AddTrainer(Trainer t)
        {
            db.Trainers.Add(t);
            db.SaveChanges();
        }

        public void Edit(Trainer t)
        {
            if (t != null)
            {
                db.Trainers.Update(t);
                db.SaveChanges();
            }

        }

        public void EditExp(TrainerExperience e)
        {
            if (e != null)
            {
                db.TrainerExperiences.Update(e);
                db.SaveChanges();
            }
        }

        public void EditQua(TrainerQualification q)
        {
            if (q != null)
            {
                db.TrainerQualifications.Update(q);
                db.SaveChanges();
            }
        }

        public void EditSkill(TechSkill s)
        {
            if (s != null)
            {
                db.TechSkills.Update(s);
                db.SaveChanges();
            }
        }

        public IEnumerable<TrainerQualification> GetQualifcationExp(int id)
        {
            return db.TrainerQualifications.Where(c => c.TrainerId == id).ToList();
        }

        public Trainer GetTrainerById(int id)
        {
            return db.Trainers.Where(c => c.TrainerId == id).FirstOrDefault();
        }

        public IEnumerable<TrainerExperience> GetTrainerExp(int id)
        {
            return db.TrainerExperiences.Where(c => c.TrainerId == id).ToList();
        }

        public TrainerExperience GetTrainerExp1(int userid, int expid)
        {
            return db.TrainerExperiences.Where(c => c.TrainerId == userid && c.ExperienceId == expid ).FirstOrDefault();
        }

        public TrainerQualification GetTrainerQua(int userid, int qid)
        {
            return db.TrainerQualifications.Where(c => c.TrainerId == userid && c.QualificationId == qid).FirstOrDefault();
        }

        public Trainer GetTrainers(string Email, string password)
        {
            return db.Trainers.Where(c => c.TrainerEmail == Email && c.TrainerPassword == password).FirstOrDefault();
        }

        public TechSkill GetTrainerSkill(int userid, int skid)
        {
            return db.TechSkills.Where(c => c.TrainerId == userid && c.SkillId == skid).FirstOrDefault();
        }

        public IEnumerable<TechSkill> GetTrainerSkills(int id)
        {
            return db.TechSkills.Where(c => c.TrainerId == id).ToList();
        }
    }
}
