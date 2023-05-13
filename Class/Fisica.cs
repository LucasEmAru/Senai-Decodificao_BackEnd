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
      public override double PagarImposto(float rendimento){
        if (rendimento <=1500){
          return 0;
        }else if(rendimento > 1500 && rendimento <= 5000){
          return (rendimento/100)*3;
        }else{
          return (rendimento/100)*8;
        }
      }

    }   
}