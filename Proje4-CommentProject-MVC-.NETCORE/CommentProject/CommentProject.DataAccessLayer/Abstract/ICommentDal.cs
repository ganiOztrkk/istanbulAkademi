using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommentProject.EntityLayer.Concrete;

namespace CommentProject.DataAccessLayer.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        List<Comment> GetCommentsByTitle(int id);
        List<Comment> GetCommentsByTitleWithUser(int id);
        List<Comment> GetCommentsByUserWithTitle(int id);
    }
}
