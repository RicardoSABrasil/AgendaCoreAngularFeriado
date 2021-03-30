using RestApiModeloDDD.Application.DTO;
using RestApiModeloDDD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Interface.Mapper
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutosDTO(IEnumerable<Produto> produtos);

        ProdutoDTO MapperEntityToDto(Produto produto);
    }
}
