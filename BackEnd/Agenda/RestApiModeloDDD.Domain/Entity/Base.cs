using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Entity
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}
