using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IFindeksService
    {
        IResult Findeks(int carId, int customerId);
    }
}
