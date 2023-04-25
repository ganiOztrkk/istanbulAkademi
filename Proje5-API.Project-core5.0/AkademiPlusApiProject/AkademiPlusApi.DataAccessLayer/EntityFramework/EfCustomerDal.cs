﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusApi.DataAccessLayer.Abstract;
using AkademiPlusApi.DataAccessLayer.Repositories;
using AkademiPlusApi.EntityLayer.Concrete;

namespace AkademiPlusApi.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
    }
}
