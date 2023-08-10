using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager servicemanager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            
            var values = servicemanager.TGetList();
            return View(values);
        }

        public IActionResult AddService()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            servicemanager.TAdd(service);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var values = servicemanager.TGetByID(id);

            servicemanager.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult EditService(int id)
        {

            var values = servicemanager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            servicemanager.TUpdate(service);
            return RedirectToAction("Index");
        }


    }
}
