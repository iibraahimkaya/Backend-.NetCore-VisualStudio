using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [SecuredOperation("category.list,admin")]
        [CacheAspect]
        public IDataResult<List<Category>> GetAll()
        {
            if (DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoryListed);
        }

        [SecuredOperation("category.list,admin")]
        [CacheAspect]
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId == categoryId));
        }
    }
}
