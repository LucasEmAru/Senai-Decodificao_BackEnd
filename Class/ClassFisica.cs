using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condificação_Bank_end.Class
{
    public class ClassFisica : ClassPessoa
    {
      public string? cpf { get; set; }
      public string? rg { get; set; }
      public DateTime dataNascimento { get; set; }

    }   
}