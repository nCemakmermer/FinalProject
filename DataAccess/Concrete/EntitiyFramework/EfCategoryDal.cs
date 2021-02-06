using Core.EntitiyFramework;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCategoryDal : EfEntitiyRepositoryBase<Category, NorthWindContext>,ICategoryDal
    {
       
    }
}
