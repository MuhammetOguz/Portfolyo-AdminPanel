using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard:ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
           
            ViewBag.v1= portfolioManager.TGetList().Count();
            ViewBag.v2= messageManager.TGetList().Count();
            ViewBag.v3= serviceManager.TGetList().Count();
            return View();
        }
    }
}
