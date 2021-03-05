using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        [SecuredOperation("add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
          
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }


        [SecuredOperation("delete,admin")]
        public IResult Delete(Car car)
        {
           
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [SecuredOperation("list,admin")]
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new  SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.Listed);
        }


        [SecuredOperation("list,admin")]
        [CacheAspect]
        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == carId));
        }


        [SecuredOperation("list,admin")]
        [CacheAspect]
        public IDataResult<List<Car>> GetCarByBrand(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.BrandId==brandId));
        }

        [SecuredOperation("list,admin")]
        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails());
        }

        [SecuredOperation("update,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            //ValidationTool.Validate(new CarValidator(), car);
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
