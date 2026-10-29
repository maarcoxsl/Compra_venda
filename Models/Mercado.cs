using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Compra_venda.Models {
    public class Mercado : Empresas{
        public Mercado() { }
         
     public  void ComprarAcao1(int escolhaUser) {
            double qtdAcao = 0;
            double vlrFinal = 0;

            while (!escolhaUser.Equals(2)) {
                   Console.WriteLine("Insira 1 para comprar mais ações ou 2 para fechar a conta e proseguir para o pagamento");
                   escolhaUser = int.Parse(Console.ReadLine());

                   qtdAcao++;
                   vlrFinal = precoAcao1 * qtdAcao;
                   Console.WriteLine($"Preço Final:{vlrFinal}\nNumero de ações: {qtdAcao}");

            }
            Console.WriteLine($"Ações compradas: {qtdAcao}\nPreçoFinal: {vlrFinal}");

        } 
    public void ComprarAcao2(int escolhaUser) {
            double qtdAcao = 0;
            double vlrFinal;

            while (!escolhaUser.Equals(2))
            {
                escolhaUser = int.Parse(Console.ReadLine());

                qtdAcao++;
                vlrFinal = precoAcao2 * qtdAcao;
                Console.WriteLine($"Preço Final:{vlrFinal}\nNumero de ações: {qtdAcao}");

            }
            Console.WriteLine("Compra encerrada");

        }
        public void ComprarAcao3(int escolhaUser) {
            double qtdAcao = 0;
            double vlrFinal;

            while (!escolhaUser.Equals(2))
            {
                escolhaUser = int.Parse(Console.ReadLine());

                qtdAcao++;
                vlrFinal = precoAcao3 * qtdAcao;
                Console.WriteLine($"Preço Final:{vlrFinal}\nNumero de ações: {qtdAcao}");

            }
            Console.WriteLine("Compra encerrada");
        }
        public void ComprarAcao4(int escolhaUser) {
            double qtdAcao = 0;
            double vlrFinal;
        
            while (!escolhaUser.Equals(2)) { 
                  escolhaUser = int.Parse(Console.ReadLine());

                  qtdAcao++;
                  vlrFinal = precoAcao4 * qtdAcao;
                  Console.WriteLine($"Preço Final:{vlrFinal}\nNumero de ações: {qtdAcao}");
            }
            Console.WriteLine("Compra encerrada");
        }
    


        // public void CatalagoAcoes() { } (Não usar por enquanto)


    }


}

