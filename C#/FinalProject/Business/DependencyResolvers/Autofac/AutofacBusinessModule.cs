using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            // bu iki kod WebAPI/Program.cs'de yazdığımız aşağıdaki kodların görevini üstleniyor:
            // builder.Services.AddSingleton<IProductService, ProductManager>();
            // builder.Services.AddSingleton<IProductDal, EfProductDal>();

            // burada bu yapıyı daha base bir seviyeye çekmiş olduk.
            // artık bir birkaç basit işlem ile autofac yapısından vazgeçip başka bir yapıya kolaylıkla geçebiliriz.
        }
    }
}
