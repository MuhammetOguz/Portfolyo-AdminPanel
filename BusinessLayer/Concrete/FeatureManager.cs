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
    public class FeatureManager :IFeatureService 
    {
        IFeatureDal _ıfeatureDal;

        public FeatureManager(IFeatureDal ıfeatureDal)
        {
            _ıfeatureDal = ıfeatureDal;
        }

        public void TAdd(Feature t)
        {
            _ıfeatureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
           _ıfeatureDal.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            return _ıfeatureDal.GetById(id);
        }

        public List<Feature> TGetList()
        {
            return _ıfeatureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            _ıfeatureDal.Update(t);
        }
    }
}
