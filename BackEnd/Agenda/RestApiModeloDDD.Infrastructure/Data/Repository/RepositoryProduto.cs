using RestApiModeloDDD.Core.Interface.Repository;
using RestApiModeloDDD.Domain.Entity;

namespace RestApiModeloDDD.Infrastructure.Data.Repository
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}