using Business.Abstract;
using Business.Constans;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
           ValidationTool.Validate(new BrandValidator(),brand);
            if (_brandDal.Get(b=>b.BrandName==brand.BrandName) !=null)
            {
               return new ErrorResult(Messages.BrandAddError);
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>( _brandDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return  new SuccessDataResult<Brand>( _brandDal.Get(b => b.Id == brandId));
        }

        public IResult Update(Brand brand)
        {
            ValidationTool.Validate(new BrandValidator(), brand);
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
