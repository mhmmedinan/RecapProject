using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.DTOs;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<User> GetById(int id)
        {
          return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        public IDataResult<List<UserRentalDto>> GetRentalUserId(int userId)
        {
            List<UserRentalDto> userRentalDtos = (_userDal.GetUserRentalDto(u => u.UserId == userId));
            if (userRentalDtos==null)
            {
                return new ErrorDataResult<List<UserRentalDto>>(Messages.GetErrorCarMessage);
            }
            else
            {
                return new SuccessDataResult<List<UserRentalDto>>(userRentalDtos);
            }

          
        }

        public IResult Update(User user)
        {
            var userUpdate = GetById(user.Id).Data;
            userUpdate.FirstName = user.FirstName;
            userUpdate.LastName = user.LastName;
            userUpdate.Email = user.Email;
            _userDal.Update(userUpdate);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }
    }
}
