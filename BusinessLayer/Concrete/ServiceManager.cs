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
    public class ServiceManager :IServiceServices 
    {
        IServiceDal _ıserviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _ıserviceDal = serviceDal;
        }
        public void TAdd(Service t)
        {
            _ıserviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _ıserviceDal.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _ıserviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _ıserviceDal.GetList();
        }

        public void TUpdate(Service t)
        {
            _ıserviceDal.Update(t);
        }
    }
}
