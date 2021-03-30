using RestApiModeloDDD.Core.Interface.Repository;
using RestApiModeloDDD.Core.Interface.Service;
using RestApiModeloDDD.Domain.Entity;

namespace RestApiModeloDDD.Service
{
    public class ProdutoService : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ProdutoService(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}