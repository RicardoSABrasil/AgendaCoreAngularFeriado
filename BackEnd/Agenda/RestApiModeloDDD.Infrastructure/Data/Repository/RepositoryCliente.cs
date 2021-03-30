using RestApiModeloDDD.Core.Interface.Repository;
using RestApiModeloDDD.Domain.Entity;

namespace RestApiModeloDDD.Infrastructure.Data.Repository
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}