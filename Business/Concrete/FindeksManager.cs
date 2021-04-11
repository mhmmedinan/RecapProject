using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;

namespace Business.Concrete
{
     public class FindeksManager:IFindeksService
    {
        private ICustomerService _customerService;
        private ICarService _carService;

        public FindeksManager(ICustomerService customerService, ICarService carService)
        {
            _customerService = customerService;
            _carService = carService;
        }

        public IResult Findeks(int carId, int customerId)
        {
            int carFindeks = _carService.GetById(carId).Data.Findeks;
            int customerFindeks = _customerService.GetById(customerId).Data.Findeks;
            if (carFindeks > customerFindeks)
            {
                return new ErrorResult(Messages.FindeksError);
            }

            return new SuccessResult();
        }
    }
}
