using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condificação_Bank_end.Class
{
    public class ClassJuridica : ClassPessoa
    {
     public string? cnpj { get; set; }
     public string? razaoSocial { get; set; }
    }
}