using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusApi.BusinessLayer.Abstract;
using AkademiPlusApi.DataAccessLayer.Abstract;
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

        public void TInsert(Activity t)
        {
            _activityDal.Insert(t);
        }

        public void TDelete(Activity t)
        {
            _activityDal.Delete(t);
        }

        public void TUpdate(Activity t)
        {
            _activityDal.Update(t);
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
