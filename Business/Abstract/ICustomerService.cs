using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetAllByCategoryId(int id);
        IDataResult<Customer> GetById(string customerId);
    }
}
