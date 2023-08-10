using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioServices
    {
        IPortfolioDal _ıportfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _ıportfolioDal = portfolioDal;
        }
        public void TAdd(Portfolio t)
        {
            _ıportfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _ıportfolioDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _ıportfolioDal.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return _ıportfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _ıportfolioDal.Update(t);
        }
    }
}
