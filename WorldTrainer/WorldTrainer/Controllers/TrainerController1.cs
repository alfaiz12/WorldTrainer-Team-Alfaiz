using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
namespace WorldTrainer.Controllers
{
  

    public class TrainerController1 : Controller
    {
        private readonly IRepository repo;
        public TrainerController1(IRepository myrepo)
        {
            repo = myrepo;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Home()
        {
            ViewBag.Email = Request.Cookies["Email"];
            return View();
        }
        [Authorize]
        public IActionResult Profile()
        {
            var id = Request.Cookies["Id"];
            var data = repo.GetTrainerById(Convert.ToInt32(id));
            var Exp = repo.GetTrainerExp(Convert.ToInt32(id));
            var qualification = repo.GetQualifcationExp(Convert.ToInt32(id));
            var Skill = repo.GetTrainerSkills(Convert.ToInt32(id));
            ViewBag.Qualification = qualification;
            ViewBag.Exp = Exp;
            ViewBag.Skill = Skill;
            return View(Models.Mapper.Map1(data));
        }
        [Authorize]
        public IActionResult Edit()
        {
            var id = Request.Cookies["Id"];
            var data = repo.GetTrainerById(Convert.ToInt32(id));
            return View(Models.Mapper.Map1(data));
        }
        [HttpPost]
        [Authorize]
        public IActionResult Edit(Models.TrainerModel t)
        {

            repo.Edit(Models.Mapper.Map2(t));

            return RedirectToAction("Profile");
        }
        [Authorize]
        public IActionResult EditExp(int id)
        {
            var ids = Request.Cookies["Id"];
            var data = repo.GetTrainerExp1(Convert.ToInt32(ids),id);
            return View(Models.Mapper.Map3(data));
        }
        [HttpPost]
        [Authorize]
        public IActionResult EditExp(Models.ExperinceModel e)
        {
            repo.EditExp(Models.Mapper.Map4(e));
            return RedirectToAction("Profile");
        }
        [Authorize]
        public IActionResult EditQua(int id)
        {
            var ids = Request.Cookies["Id"];
            var data = repo.GetTrainerQua(Convert.ToInt32(ids), id);
            return View(Models.Mapper.Map5(data));
        }
        [Authorize]
        [HttpPost]
        public IActionResult EditQua(Models.QualifationModel e)
        {
            repo.EditQua(Models.Mapper.Map6(e));
            return RedirectToAction("Profile");
        }
        [Authorize]
        public IActionResult EditSkill(int id)
        {
            var ids = Request.Cookies["Id"];
            var data = repo.GetTrainerSkill(Convert.ToInt32(ids), id);
            return View(Models.Mapper.Map7(data));
        }
        [Authorize]
        [HttpPost]
        public IActionResult EditSkill(Models.SkillModel e)
        {
            repo.EditSkill(Models.Mapper.Map8(e));
            return RedirectToAction("Profile");
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddExp()
        {
            ViewBag.Id= Request.Cookies["Id"];
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddExp(Models.ExperinceModel e)
        {
            if (ModelState.IsValid) {
                repo.AddExp(Models.Mapper.Map9(e));
                return RedirectToAction("Profile");
            }
            else
            {
                return View();
            }
        }
        [Authorize]
        public IActionResult AddQua()
        {
            ViewBag.Id = Request.Cookies["Id"];
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddQua(Models.QualifationModel e)
        {
            if (ModelState.IsValid)
            {
                repo.AddQua(Models.Mapper.Map10(e));
                return RedirectToAction("Profile");
            }
            else
            {
                return View();
            }
        }
        [Authorize]
        public IActionResult AddSkill()
        {
            ViewBag.Id = Request.Cookies["Id"];
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult AddSkill(Models.SkillModel e)
        {
            if (ModelState.IsValid)
            {
                repo.AddSkill(Models.Mapper.Map11(e));
                return RedirectToAction("Profile");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Models.TrainerModel t)
        {
            if (ModelState.IsValid)
            {
                repo.AddTrainer(Models.Mapper.Map13(t));
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return RedirectToAction("Signup");
            }
        }
     
    }
}
