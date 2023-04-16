using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condificação_Bank_end.Class
{
    public class Fisica : Pessoa
    {
      public string? cpf { get; set; }
      public string? rg { get; set; }
      public DateTime dataNascimento { get; set; }
      public override void PagarImposto(float rendimento){}

    }   
}