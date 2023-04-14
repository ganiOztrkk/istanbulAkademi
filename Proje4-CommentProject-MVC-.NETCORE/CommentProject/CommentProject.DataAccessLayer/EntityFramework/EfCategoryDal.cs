﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommentProject.DataAccessLayer.Abstract;
using CommentProject.DataAccessLayer.Repositories;
using CommentProject.EntityLayer.Concrete;

namespace CommentProject.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category> , ICategoryDal
    {
    }
}
