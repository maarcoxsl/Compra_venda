using Compra_venda.Models;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
/* implementação
   1 -
   2 - 

*/
namespace Compra_venda { 
    internal class Program { 
       public  static void Main() {
            Program principal = new Program();
            principal.SistemAcoes();
            //principal.AreaTitular();
           }
        public void  Cadastro(){
              CadastroUsuario infoU = new CadastroUsuario();
              Console.WriteLine("==== Área de cadastro ====");
              Console.WriteLine();
              Console.WriteLine();
              Console.WriteLine("Insira o seu nome");
              infoU.NomeUsuario = infoU.GetNome(Console.ReadLine());
              Console.WriteLine("Insira a sua idade");
              infoU.IdadeUsuario = infoU.GetIdade(int.Parse(Console.ReadLine()));
              Console.WriteLine();
              Console.WriteLine("Insira o seu perfil de investidor");
              Console.WriteLine("1) Passivo");
              Console.WriteLine("2) Conservador");
              Console.WriteLine("3) Agressivo");
              infoU.PerfilInvestidor = infoU.GetPerfil(int.Parse(Console.ReadLine()));
            }
       
     
        public void AreaTitular(){ 
            AreaTitular aT = new AreaTitular();
            try { 
            Console.WriteLine("Insira o quanto de dinheiro você quer por");
            aT.Saldo = aT.RegraSaldo(double.Parse(Console.ReadLine()));
            }
            catch (Exception ex) { Console.WriteLine($"Informação errada renicie o progama e tente novamente: {ex.Message}"); 
            }
        }
     
        public void CatalogoAcoes() {
            Empresas nomes = new Empresas();

            Console.WriteLine("==== Catalogo ====");
            Console.WriteLine();
            Console.WriteLine($"Nome ação: 1){nomes.nomeEmpresa1}");
            Console.WriteLine($"Codigo: {nomes.acaoEmpresa1}");
            Console.WriteLine($"Preço: {nomes.precoAcao1}");
            Console.WriteLine();
            Console.WriteLine($"Nome ação: 2){nomes.nomeEmpresa2}");
            Console.WriteLine($"Código: {nomes.acaoEmpresa2}");
            Console.WriteLine($"Preço: {nomes.precoAcao2}");
            Console.WriteLine();
            Console.WriteLine($"Nome: 3){nomes.acaoEmpresa3}");
            Console.WriteLine($"Código: {nomes.acaoEmpresa3}");
            Console.WriteLine($"Preço: {nomes.precoAcao3}");
            Console.WriteLine();
            Console.WriteLine($"Nome: 4){nomes.acaoEmpresa4}");
            Console.WriteLine($"Código: {nomes.acaoEmpresa4}");
            Console.WriteLine($"Preço: {nomes.precoAcao4}");
        }
        public void EscolhaCompra() {
            Empresas empresa = new Empresas();
            int escolhaCompra;

            try {
                Console.WriteLine("Insira qual ação você deseja comprar de acordo com catalogo");
                escolhaCompra = int.Parse(Console.ReadLine());

               

            } catch { 
            Console.WriteLine("Insira qual ação você deseja comprar de acordo com catalogo");
                  escolhaCompra = int.Parse(Console.ReadLine());
            
            }
        
            switch (escolhaCompra) {
                case 1:
                    double comando;
                    Console.WriteLine($"Você Escolheu ações da Petrobras\nPreço: {empresa.precoAcao1}");
                    Console.WriteLine("Quantas açoes você deseja comprar");
                    Console.WriteLine();
                    Console.WriteLine("Digite\n1) Iniciar as compras\n2) Não iniciar ");
                    comando = int.Parse(Console.ReadLine());
                    while (comando != 2) {
                           double qtdAcao = 0;
                           double vlrFinal;
                           Console.WriteLine("1) Comprar uma ação\n2)Fechar conta");
                           comando = double.Parse(Console.ReadLine());
                           
                           qtdAcao++;
                           vlrFinal = empresa.precoAcao1 * qtdAcao;
                           
                           Console.WriteLine($"Preço atual: {vlrFinal}\nAções compradas: {qtdAcao}");

                        if (comando == 2){
                            Console.WriteLine("Conta encerrada");
                            Console.WriteLine($"Valor Final: {vlrFinal}");

                        }
                           
                    }
                    break;
                case 2:
                    Console.WriteLine($"Você escolheu ações da Vale\nPreço: {empresa.precoAcao2}");
                    Console.WriteLine("Quantas ações você deseja comprar");
                    break;
                case 3:
                    Console.WriteLine($"Você escolheu  ações do Itau\nPreço{empresa.precoAcao3}");
                    Console.WriteLine("Quantas ações você deseja comprar");
                    break;
                case 4:
                    Console.WriteLine($"Você Escolheu ações da Magazine Luiza\nPreço: {empresa.precoAcao4}");
                    Console.WriteLine("Quantas ações você deseja comprar");
                    break;      
            } 
        }
        public void SistemAcoes() {
            Program chamarMet = new Program();
            int guardarResposta;
            Console.WriteLine("==== Sistema de compra e venda de ações ====");
            Console.WriteLine();
            Console.WriteLine("Faça o cadastro em nosso sistema");
            chamarMet.Cadastro();
            Console.WriteLine("Cadastro realizado com sucesso a seguir veja o catalogo e escolha qual ação comprar");
            chamarMet.CatalogoAcoes();
            chamarMet.EscolhaCompra();
            
            guardarResposta = int.Parse(Console.ReadLine());
           
             Console.WriteLine("Você encerrou o progama");
          }
        }
    }
