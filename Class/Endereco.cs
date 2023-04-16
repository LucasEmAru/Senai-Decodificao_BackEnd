using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condificação_Bank_end.Class
{
    public class Endereco
    {
        public string? Logradouro {get ; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public bool enderecoComercial { get; set; }
    }
}