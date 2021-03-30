using Autofac;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interface;
using RestApiModeloDDD.Application.Interface.Mapper;
using RestApiModeloDDD.Application.Mapper;
using RestApiModeloDDD.Core.Interface.Repository;
using RestApiModeloDDD.Core.Interface.Service;
using RestApiModeloDDD.Infrastructure.Data.Repository;
using RestApiModeloDDD.Service;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();

            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();

            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion IOC
        }
    }
}