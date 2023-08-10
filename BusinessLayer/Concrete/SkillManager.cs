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
    public class SkillManager : ISkillService
    {
        ISkillDal _ıskillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _ıskillDal = skillDal;
        }
        public void TAdd(Skill t)
        {
            _ıskillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _ıskillDal.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return _ıskillDal.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return _ıskillDal.GetList();
        }

        public void TUpdate(Skill t)
        {
            _ıskillDal.Update(t);
        }
    }
}
