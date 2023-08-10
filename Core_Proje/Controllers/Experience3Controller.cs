using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
    public class Experience3Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            var values = JsonConvert.SerializeObject(experience);
            return Json(values);
        }
        public IActionResult GetById(int ExperienceID)
        {
            var v = experienceManager.TGetByID(ExperienceID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }


        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return NoContent();
        }

        public IActionResult UpdateExperience(Experience p)
        {
            var v = experienceManager.TGetByID(p.ExperienceID);
            experienceManager.TUpdate(v);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

    }
}
