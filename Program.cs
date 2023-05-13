using System;
using Condificação_Bank_end.Class;

class Program {
   static void Main(string[] args){  

      void BarraCarregamento(){
      Console.WriteLine("Iniciando");{
      Thread.Sleep(500);
   
      for (var Contador = 0; Contador < 10; Contador++){
      Console.Write(".");
      Thread.Sleep(500);
      }
   }

      Console.Clear();
     

     }
   
   Console.ForegroundColor = ConsoleColor.DarkGreen; 
 BarraCarregamento();
 string opcao;
do{   
   Console.WriteLine(@$"
   ------------------------------------------------------------------------------------
   |                                                                                  |
   |                        Cadastro Pessoa física e juridica                         |
   |                                                                                  |
   ------------------------------------------------------------------------------------
                                                                                     
                                  1°- Pessoa Física                                  
                                  2°- Pessoa Juridica                                
                                          Sair                                       
                                                                                  
                                                                                
");
opcao = Console.ReadLine();

   switch (opcao){
    case "1":
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

     Console.WriteLine("Opção escolhida: Pessoa Física." );
     Console.WriteLine($"Usuario {novapf.nome} do CPF {novapf.cpf} Nascido em {novapf.dataNascimento}, Endereço {novapf.Endereco.Logradouro}, N° {novapf.Endereco.Numero}");
     Console.WriteLine(novapf.Endereco.Complemento);
     Console.WriteLine(novapf.Endereco.enderecoComercial);
    break;
    case "2":   
     Endereco enderecoCurtume = new Endereco(); 
     enderecoCurtume.Logradouro = "Rajada, Rua Joventina Jovem";
     enderecoCurtume.Numero = 175;
     enderecoCurtume.Complemento = "Empresa";
     enderecoCurtume.enderecoComercial = true;

    Juridica novapj = new Juridica();
      
      novapj.Endereco = enderecoCurtume;
      novapj.nome = "Curtume Moderno";
      novapj.cnpj = "1234567890001";

      if (novapj.ValidarCNPJ(novapj.cnpj)){
         Console.WriteLine("CNPJ Valido");
      }else{
      Console.WriteLine("CNPJ Invalido");
      }
     Console.WriteLine($"Usuario {novapj.nome} do CNPJ {novapj.cnpj}, Endereço {novapj.Endereco.Logradouro}, N° {novapj.Endereco.Numero}");
     Console.WriteLine(novapj.Endereco.Complemento);
     Console.WriteLine(novapj.Endereco.enderecoComercial);
    break;
    case "Sair":
     Console.WriteLine("Finalizado." );
    break;
    default:
     Console.WriteLine("Opção Invalida, escolha uma das opções apresentadas.");
    break;
   } 
   }while(opcao != "Sair");

   }
}
