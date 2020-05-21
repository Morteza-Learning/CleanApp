using Data.Database;
using Data.Entities;
using Data.Mappers;
using Data.Repository;
using Domain.Entities;
using Domain.Mappers;
using Domain.Repository;
using Domain.UseCases;
using Ninject.Modules;

namespace CleanApp.WireUp
{
    public class OrderWireUp : NinjectModule
    {
        public override void Load()
        {
            var apiKey = Properties.Settings.Default.SALMAli;
            Bind<IMapper<OrderData, OrderEntity>>().To<OrderMapper>();
            Bind<IDatabase>().To<DatabaseEF>().WithConstructorArgument(apiKey);
            Bind<IOrderRepository>().To<OrderRepository>();
            Bind<GetOrderInteractor>().ToSelf().InSingletonScope();
        }
    }
}