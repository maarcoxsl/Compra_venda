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
            pricipal.SistemAcoes();
           }
        public void CatalogoAcoes() {
            Acoes nomes = new Acoes();

            nomes.nomeEmpresa1 = "Petrobras";
            nomes.acaoEmpresa1 = "PETR4";

            nomes.nomeEmpresa2 = "Vale";
            nomes.acaoEmpresa2 = "VALE3";

            nomes.nomeEmpresa3 = "Itau";
            nomes.acaoEmpresa3 =  "ITUB4";

            nomes.acaoEmpresa4 = "Magazine Luiza";
            nomes.acaoEmpresa4 = "MGLU3";

            Console.WriteLine("==== Catalogo ====");
            Console.WriteLine();
            Console.WriteLine($"Nome ação: {nomes.nomeEmpresa1}");
            Console.WriteLine($"Codigo: {nomes.acaoEmpresa1}");
            Console.WriteLine($"Nome ação: {nomes.nomeEmpresa2}");
            Console.WriteLine($"Código: {nomes.acaoEmpresa2}");
            Console.WriteLine($"Nome: {nomes.acaoEmpresa3}");
            Console.WriteLine($"Código: {nomes.acaoEmpresa3}");
            Console.WriteLine($"Nome: {nomes.acaoEmpresa4}");
            Console.WriteLine($"Código: {nomes.acaoEmpresa4}");  
        }

        public void EscolhaCompra() {
            int escolhaCompra;

            Console.WriteLine("Insira qual ação você deseja comprar de acordo com catalogo");
            escolhaCompra = int.Parse(Console.ReadLine());

            switch (escolhaCompra) {
                case 1:
                    Console.WriteLine("Você acabou de comprar as ações da Petrobras");
                    break;
                case 2:
                    Console.WriteLine("Você acabou de comprar as ações da Vale");
                    break;
                case 3:
                    Console.WriteLine("Você acabou de comprar as ações do itau");
                    break;
                case 4:
                    Console.WriteLine("Você acabou de comprar as ações da magazine luiza");
                    break;
              
            }
            
        }
        public void SistemAcoes() {
            Program chamarMet = new Program();
            Console.WriteLine("==== Sistema de compra e venda de ações ====");
            Console.WriteLine();
            Console.WriteLine("Veja a seguir o catalogo a seguir e em seguida escolha qual ação você irá comprar");
            chamarMet.CatalogoAcoes();
            chamarMet.EscolhaCompra();
          }
        }
    }
