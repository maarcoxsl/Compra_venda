using Compra_venda.Models;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
/* implementação
   1 - Colocar a POO
   2 - Tentar colocar a data e hora da compra da ação

*/
namespace Compra_venda { 

    internal class Program { 
       public  static void Main() {
            Program pricipal = new Program();
            CadastroUsuario info = new CadastroUsuario(); 
            pricipal.SistemAcoes();
           }

        public void  Cadastro(){
              CadastroUsuario infoU = new CadastroUsuario();
              Console.WriteLine("==== Área de cadastro ====");
              Console.WriteLine();
              Console.WriteLine();
              Console.WriteLine("Insira o seu nome");
              infoU.nomeUsuario = Console.ReadLine();
              Console.WriteLine("Insira a sua idade");
              infoU.idadeUsuario = int.Parse(Console.ReadLine());
              Console.WriteLine();
              Console.WriteLine("Insira o seu perfil de investidor");
              Console.WriteLine("1) Passivo");
              Console.WriteLine("2) Conservador");
              Console.WriteLine("3) Agressivo");
              infoU.perfilInvestidor = int.Parse(Console.ReadLine());
            }
        public void VerificaConta(int escolheOp) {
            while (escolheOp != 1 && escolheOp != 2)
            { Console.WriteLine("tt");
                if (escolheOp == 1){
                   Console.WriteLine("Você tem conta");
                   Console.WriteLine("Bem vindo");

                } else if (escolheOp == 2){
                  Console.WriteLine("Você não tem conta");
                  Console.WriteLine("Crie uma");
                }
           
                
                 Console.WriteLine("Crie uma conta");


           
                } //while (escolheOp != 1 && escolheOp != 2);
        } 

        public void CatalogoAcoes() {
            Empresas nomes = new Empresas();

            Console.WriteLine("==== Catalogo ====");
            Console.WriteLine();
            Console.WriteLine($"Nome ação: {nomes.nomeEmpresa1}");
            Console.WriteLine($"Codigo: {nomes.acaoEmpresa1}");
            Console.WriteLine($"Preço: {nomes.precoAcao1}");
            Console.WriteLine();
            Console.WriteLine($"Nome ação: {nomes.nomeEmpresa2}");
            Console.WriteLine($"Código: {nomes.acaoEmpresa2}");
            Console.WriteLine($"Preço: {nomes.precoAcao2}");
            Console.WriteLine();
            Console.WriteLine($"Nome: {nomes.acaoEmpresa3}");
            Console.WriteLine($"Código: {nomes.acaoEmpresa3}");
            Console.WriteLine($"Preço: {nomes.precoAcao3}");
            Console.WriteLine();
            Console.WriteLine($"Nome: {nomes.acaoEmpresa4}");
            Console.WriteLine($"Código: {nomes.acaoEmpresa4}");
            Console.WriteLine($"Preço: {nomes.precoAcao4}");
        }
        public void EscolhaCompra() {
            Empresas empresa = new Empresas();
            int escolhaCompra;

            Console.WriteLine("Insira qual ação você deseja comprar de acordo com catalogo");
            escolhaCompra = int.Parse(Console.ReadLine());

            switch (escolhaCompra) {
                case 1:
                    Console.WriteLine($"Você acabou de comprar as ações da Petrobras\nPreço: {empresa.precoAcao1}");
                    break;
                case 2:
                    Console.WriteLine($"Você acabou de comprar as ações da Vale\nPreço: {empresa.precoAcao2}");
                    break;
                case 3:
                    Console.WriteLine($"Você acabou de comprar as ações do itau\nPreço{empresa.precoAcao3}");
                    break;
                case 4:
                    Console.WriteLine($"Você acabou de comprar as ações da Magazine Luiza\nPreço: {empresa.precoAcao4}");
                    break;      
            } 
        }
        public void SistemAcoes() {
            Program chamarMet = new Program();
            int guardarResposta;
            Console.WriteLine("==== Sistema de compra e venda de ações ====");
            Console.WriteLine();
            Console.WriteLine("Você possui cadastro em nossa loja");
            Console.WriteLine("1) sim");
            Console.WriteLine("2) não");
            guardarResposta = int.Parse(Console.ReadLine());
            chamarMet.VerificaConta(guardarResposta); 
           // chamarMet.CatalogoAcoes();
            //chamarMet.EscolhaCompra();
          }
        }
    }
