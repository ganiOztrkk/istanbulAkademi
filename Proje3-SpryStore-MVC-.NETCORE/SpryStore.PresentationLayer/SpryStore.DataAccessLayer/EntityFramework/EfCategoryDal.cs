﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryStore.DataAccessLayer.Abstract;
using SpryStore.DataAccessLayer.Repositories;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
