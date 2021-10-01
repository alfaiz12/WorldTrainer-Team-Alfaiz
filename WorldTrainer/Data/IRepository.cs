using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository
    {
        public Trainer GetTrainers(string Email, string password);
        public Trainer GetTrainerById(int id);
        public void Edit(Trainer t);
        public void EditExp(TrainerExperience e);
        public void EditQua(TrainerQualification q);
        public void EditSkill(TechSkill s);
        public IEnumerable<TrainerExperience> GetTrainerExp(int id);
        public TrainerExperience GetTrainerExp1(int userid,int expid);
        public TrainerQualification GetTrainerQua(int userid, int expid);
        public TechSkill GetTrainerSkill(int userid, int expid);
        public IEnumerable<TrainerQualification> GetQualifcationExp(int id);
        public IEnumerable<TechSkill> GetTrainerSkills(int id);
        public void AddExp(TrainerExperience t);
        public void AddQua(TrainerQualification t);
        public void AddSkill(TechSkill t);
        public void AddTrainer(Trainer t);

    }
}
