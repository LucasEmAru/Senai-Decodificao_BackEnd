using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condificação_Bank_end.Class
{
    public class Juridica : Pessoa
   {
     public string? cnpj { get; set; }
     public string? razaoSocial { get; set; }
     public override double PagarImposto(float rendimento){
        if (rendimento <=5000){
          return (rendimento/100)*6;
        }else if(rendimento > 5000 && rendimento <= 10000){
          return (rendimento/100)*8;
        }else{
          return (rendimento/100)*1;
        }
     }

  public bool ValidarCNPJ(string cnpj)  {
    if(cnpj.Length >= 14 && (cnpj.Substring(cnpj.Length - 4)) == "0001"){
      
     return true;

     } else{
       return false;
     }
    
     } 

    }
}