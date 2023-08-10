using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{

    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {


        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());

        public IActionResult Index()
        {
            var values = announcementManager.TGetList();
            return View(values);
        }

        public IActionResult Details(int id)
        {
           Announcement announcement= announcementManager.TGetByID(id);
            return View(announcement);

        }
    }
}
