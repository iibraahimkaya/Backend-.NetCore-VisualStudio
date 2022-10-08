using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [SecuredOperation("claim.list,admin")]
        [CacheAspect]
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        [SecuredOperation("user.list,admin")]
        [CacheAspect]
        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
        [SecuredOperation("user.add,admin")]
        [CacheRemoveAspect("IUserService.Get")]
        public void Add(User user)
        {
            _userDal.ADD(user);
        }
    }
}
