using Business.Abstract;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcers.Logging.Log4Net.Loggers;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Business.BusinessAspect.Autofac;
using Business.Constans;

namespace Business.Concrete
{

    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        
        
        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }
        
        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                State = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, "kayıt başarılı");
        }
       
        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null )
            {
                return new ErrorDataResult<User>("Kullanıcı bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<User>("parola hatası");
            }

           
          

            return new SuccessDataResult<User>(userToCheck.Data,"giriş başarılı");
        }

       
       

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email).Data != null)
            {
                return new ErrorResult("önceden kullanıcı kayıt edilmiş");
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims.Data);
            return new SuccessDataResult<AccessToken>(accessToken,"token oluşturuldu");
        }

        public IResult ChangePassword(ChangePasswordDto changePasswordDto)
        {
            byte[] passwordHash, passwordSalt;
            var userToCheck = _userService.GetById(changePasswordDto.UserId).Data;
            if (userToCheck == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            if (!HashingHelper.VerifyPasswordHash(changePasswordDto.OldPassword, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorResult(Messages.PasswordError);
            }
            HashingHelper.CreatePasswordHash(changePasswordDto.NewPassword, out passwordHash, out passwordSalt);
            userToCheck.PasswordHash = passwordHash;
            userToCheck.PasswordSalt = passwordSalt;
            _userService.Update(userToCheck);
            return new SuccessResult(Messages.PasswordChanged);
        }
    }
}
