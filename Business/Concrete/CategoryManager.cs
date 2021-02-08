﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            // is kodlari
            return _categoryDal.GetAll();
        }
        // Select * from Categories where CategoryId=3
        public Category GetById(int categoryid)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryid);
        }
    }
}
