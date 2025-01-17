﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
  public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetById(int categoryId);
        List<Category> GetByName(string category);


    }
}
