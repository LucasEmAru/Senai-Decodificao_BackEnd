using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condificação_Bank_end.Class
{
    public abstract class Pessoa
    {
        public string? nome { get; set;}

        public Endereco? Endereco { get; set; }

       public abstract void PagarImposto(float rendimento);

       public bool ValidarDatadeNascimento(DateTime dateNascimento){
        DateTime dataAtual = DateTime.Today;

        double anos = (dataAtual - dateNascimento).TotalDays / 365;

        if(anos >= 18){
            return true;
        }else{
            return false;
        }
       }
    }
}