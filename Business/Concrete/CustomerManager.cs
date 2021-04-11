using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constans;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerUserId(int userId)
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(
                _customerDal.GetCustomerUserId(u => u.UserId == userId));
        }


        [CacheRemoveAspect("ICustomerService.Get")]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }
        
        public IResult Delete(Customer customer)
        {

            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c=>c.Id==customerId));
        }


        [CacheAspect]
        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails());
        }
        [CacheRemoveAspect("ICustomerService.Get")]
        public IResult Update(Customer customer)
        {

            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
