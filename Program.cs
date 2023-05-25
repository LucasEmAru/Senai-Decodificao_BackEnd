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
 
 List<Fisica> listaPf = new List<Fisica>(); 
 
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
 string opcaoPF;
 
 
   switch (opcao){
    case "1":

    do{
      Console.Clear();
      Console.WriteLine(@$"
   ------------------------------------------------------------------------------------
   |                                                                                  |
   |                          Escolha uma das opções abaixo                           |
   |                                                                                  |
   ------------------------------------------------------------------------------------
                                                                                     
                              1°- Cadastrar Pessoa Física                                  
                              2°- Mostrar Pessoas Cadastradas                               
                                          Voltar                                      
                                                                                  
                                                                                
");
     opcaoPF = Console.ReadLine();
   switch (opcaoPF){
       case "1":
       Endereco endereco = new Endereco(); 
       Fisica novapf = new Fisica();

       Console.WriteLine("Digite o nome para cadastro.");
       novapf.nome = Console.ReadLine();
       Console.WriteLine("Digite o CPF.");
       novapf.cpf = Console.ReadLine();
       Console.WriteLine("Digite a data de nascimento. Ex:Dia/mês/Ano");
       novapf.dataNascimento = DateTime.Parse(Console.ReadLine());
       novapf.Endereco = endereco;
       
       Console.WriteLine("Digite o endereço para o cadastro.");
       endereco.Logradouro = Console.ReadLine(); 
       Console.WriteLine("Número da residencia.");
       endereco.Numero = int.Parse(Console.ReadLine());
       Console.WriteLine("Complemento.");
       endereco.Complemento = Console.ReadLine(); 
       Console.WriteLine("Comercial? SIM/NÃO.");
       string endCom = Console.ReadLine().ToUpper();
       
       if(endCom == "SIM"){
          endereco.enderecoComercial = true;
       } else{ 
          endereco.enderecoComercial = false;         
       }

       //listaPf.Add(novapf);
       
       
       
       using( StreamWriter sw = new StreamWriter($"{novapf.nome}")){
               sw.WriteLine(novapf.nome);
               sw.WriteLine(novapf.dataNascimento);
       };
       Console.WriteLine("Cadastro concluido");
       Thread.Sleep(5000);
       break;
       case "2": 
       Console.WriteLine("$ Quem você deseja consultar?");
       string Registro = Console.ReadLine();
       using(StreamReader sr = new StreamReader($"{Registro}.txt")){
             string linha;
             while ((linha = sr.ReadLine()) != null){
               Console.WriteLine("{$ linha}");
             };
       };
       Console.WriteLine("Precione qualquer tecla para continuar");
       Console.ReadLine();
       break;
       case "Voltar":
       break;
       default:
       Console.Clear();
       Console.WriteLine("Opção Invalida, escolha uma das opções apresentadas.");
       Thread.Sleep(2000);
       break;
   }
     }while(opcaoPF != "Voltar");
    
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
