﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusApi.DataAccsessLayer.Abstract;
using AkademiPlusApi.DataAccsessLayer.Repositories;
using AkademiPlusApi.EntityLayer.Concrete;

namespace AkademiPlusApi.DataAccsessLayer.EntityFramework
{
    public class EfBalanceDal : GenericRepository<Balance>, IBalanceDal
    {
    }
}