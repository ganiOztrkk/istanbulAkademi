using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CommentProject.BusinessLayer.Abstract;
using CommentProject.DataAccessLayer.Abstract;
using CommentProject.EntityLayer.Concrete;

namespace CommentProject.BusinessLayer.Concrete
{
    public class TitleManager : ITitleService
    {
        private readonly ITitleDal _titleDal;

        public TitleManager(ITitleDal titleDal)
        {
            _titleDal = titleDal;
        }

        public void TInsert(Title t)
        {
            _titleDal.Insert(t);
        }

        public void TUpdate(Title t)
        {
            _titleDal.Update(t);
        }

        public void TDelete(Title t)
        {
            _titleDal.Delete(t);
        }

        public List<Title> TGetList()
        {
            return _titleDal.GetList();
        }

        public Title TGetByID(int id)
        {
            return _titleDal.GetByID(id);
        }

        public List<Title> TGetListByFilter(Expression<Func<Title, bool>> filter)
        {
            return _titleDal.GetListByFilter(filter);
        }
    }
}
