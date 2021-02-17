using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICarService>().To<CarManager>().InSingletonScope();
            Bind<ICarDal>().To<EfCarDal>().InSingletonScope();

            Bind<IBrandService>().To<BrandManager>().InSingletonScope();
            Bind<IBrandDal>().To<EfBrandDal>().InSingletonScope();

            Bind<IColorService>().To<ColorManager>().InSingletonScope();
            Bind<IColorDal>().To<EfColorDal>().InSingletonScope();

            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

            Bind<IRentalService>().To<RentalManager>().InSingletonScope();
            Bind<IRentalDal>().To<EfRentalDal>().InSingletonScope();


        }
    }
}
