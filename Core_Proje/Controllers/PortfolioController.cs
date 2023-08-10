using BusinessLayer.Concrete;
using BusinessLayer.ValidationRule;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
           
            var values = portfolioManager.TGetList();
            return View(values);
        }

        public IActionResult AddPortfolio()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {


            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);

            if (results.IsValid)
            {
                portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);

            portfolioManager.TDelete(values);

            return RedirectToAction("Index");
        }

        public IActionResult EditPortfolio(int id)
        {
          
            var values = portfolioManager.TGetByID(id);
           return View(values);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {

            portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");

            //PortfolioValidator validations = new PortfolioValidator();
            //ValidationResult results = validations.Validate(portfolio);
            //if (results.IsValid)
            //{
            //    portfolioManager.TUpdate(portfolio);
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}

            //return RedirectToAction("Index");

        }

    }
}
