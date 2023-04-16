using System;
using Condificação_Bank_end.Class;

class Program {
    static void Main(string[] args)
    {
     Endereco enderecoLucas = new Endereco(); 
     enderecoLucas.Logradouro = "Cosme e Damião, Avenida 2";
     enderecoLucas.Numero = 362;
     enderecoLucas.Complemento = "Apartamentos/Condominios";
     enderecoLucas.enderecoComercial = true;

     Fisica novapf = new Fisica();
     novapf.cpf = "000000000-00";
     novapf.Endereco = enderecoLucas;
     novapf.dataNascimento = new DateTime (2010, 05, 31 , 09 , 01 , 00 );
     novapf.nome = "Lucas";

     
     
     Console.WriteLine($"Usuario {novapf.nome} do CPF {novapf.cpf} Nascido em {novapf.dataNascimento}, Endereço {novapf.Endereco.Logradouro}, N° {novapf.Endereco.Numero}");
     Console.WriteLine(novapf.Endereco.Complemento);
     Console.WriteLine(novapf.Endereco.enderecoComercial);
     
     bool IdadeValidada = novapf.ValidarDatadeNascimento(novapf.dataNascimento);
     if (IdadeValidada == true){
        Console.WriteLine($"Maior de idade");  
     }else{
        Console.WriteLine($"Menor de idade");
     }

     }
}