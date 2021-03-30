using RestApiModeloDDD.Application.DTO;
using RestApiModeloDDD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Interface.Mapper
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientesDTO(IEnumerable<Cliente> clientes);

        ClienteDTO MapperEntityToDto(Cliente cliente);
    }
}
