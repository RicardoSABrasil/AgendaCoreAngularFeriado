using RestApiModeloDDD.Application.DTO;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interface
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDTO produtoDTO);

        void Update(ProdutoDTO produtoDTO);

        void Remover(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> GetAll();

        ProdutoDTO GetById(int id);
    }
}