using Core.EntitiyFramework;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
   public class EfOrderDal : EfEntitiyRepositoryBase<Order, NorthWindContext>, IOrderDal
    {
    }
}
