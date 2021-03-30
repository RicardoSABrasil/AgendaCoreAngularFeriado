using RestApiModeloDDD.Core.Interface.Repository;
using RestApiModeloDDD.Core.Interface.Service;
using RestApiModeloDDD.Domain.Entity;

namespace RestApiModeloDDD.Service
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}