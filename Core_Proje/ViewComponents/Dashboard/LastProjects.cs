using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class LastProjects:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
            var values=portfolioManager.TGetList().OrderByDescending(x=> x.PortfolioID).Take(5).ToList();
            return View(values);
        }
    }
}
