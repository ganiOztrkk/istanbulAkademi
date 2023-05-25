using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusApi.DataAccsessLayer.Abstract;
using AkademiPlusApi.DataAccsessLayer.Concrete;
using AkademiPlusApi.DataAccsessLayer.Repositories;
using AkademiPlusApi.EntityLayer.Concrete;

namespace AkademiPlusApi.DataAccsessLayer.EntityFramework
{
    public class EfBalanceDal : GenericRepository<Balance>, IBalanceDal
    {
    }
}
