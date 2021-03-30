using RestApiModeloDDD.Application.DTO;
using RestApiModeloDDD.Application.Interface.Mapper;
using RestApiModeloDDD.Domain.Entity;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDTO produtoDTO)
        {
            return new Produto()
            {
                Id = produtoDTO.Id,
                Nome = produtoDTO.Nome,
                Valor = produtoDTO.Valor
            };
        }

        public ProdutoDTO MapperEntityToDto(Produto produto)
        {
            return new ProdutoDTO()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
        }

        public IEnumerable<ProdutoDTO> MapperListProdutosDTO(IEnumerable<Produto> produtos)
        {
            return produtos.Select(s => new ProdutoDTO
            {
                Id = s.Id,
                Nome = s.Nome,
                Valor = s.Valor
            });
        }
    }
}