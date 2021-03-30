using System;

namespace RestApiModeloDDD.Domain.Entity
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        
        public bool  IsAtivo { get; set; }
    }
}
