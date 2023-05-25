using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusApi.BusinessLayer.Abstract;
using AkademiPlusApi.DataAccsessLayer.Abstract;
using AkademiPlusApi.EntityLayer.Concrete;

namespace AkademiPlusApi.BusinessLayer.Concrete
{
    public class ActivityManager : IActivityService
    {
        private readonly IActivityDal _activityDal;

        public ActivityManager(IActivityDal activityDal)
        {
            _activityDal = activityDal;
        }

        public void TInsert(Activity entity)
        {
            _activityDal.Insert(entity);
        }

        public void TDelete(Activity entity)
        {
            _activityDal.Delete(entity);
        }

        public void TUpdate(Activity entity)
        {
            _activityDal.Update(entity);
        }

        public List<Activity> TGetList()
        {
            return _activityDal.GetList();
        }

        public Activity TGetByID(int id)
        {
            return _activityDal.GetByID(id);
        }
    }
}
