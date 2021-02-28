﻿using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Results;
using Core.Utilities.Business;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var result = BusinessRules.Run(CheckIfRentalDelivery(rental.CarId));
            if (result!=null)
            {
                return result;
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetail()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult UpdateReturnDate(Rental rental)
        {
            var result = BusinessRules.Run(CheckIfRentalReturnUpdate(rental.CarId));
            if (result!=null)
            {
                return result;
            }
           
            return new SuccessResult(Messages.RentalUpdatedReturnDate);
        }

        private IResult CheckIfRentalDelivery(int carId) 
        {
            var result = _rentalDal.GetAll(r=>r.CarId==carId && r.ReturnDate==null);
            if (result.Count>0)
            {
                return new ErrorResult(Messages.RentalInValid);
            }
            return new SuccessResult();
        }
        private IResult CheckIfRentalReturnUpdate(int carId) 
        {
            var result = _rentalDal.GetAll(r=>r.CarId==carId);
            var updateRental = result.LastOrDefault();
            if (updateRental.ReturnDate!=null)
            {
                return new ErrorResult(Messages.RentalUpdatedReturnDateError);
            }
            updateRental.ReturnDate = DateTime.Now;
            _rentalDal.Update(updateRental);
            return new SuccessResult();
        }

        
    }
}
