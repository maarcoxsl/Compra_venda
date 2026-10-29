using System;
using System.Collections.Generic;
using System.Text;

namespace Compra_venda.Models {
    // get  == leitura
    // set == alterar valor
    // Nome
    // Perfil
    public class AreaTitular : CadastroUsuario {
      public AreaTitular() { }
      public AreaTitular(string nomeUsuario) : base(nomeUsuario) { }
      public double Saldo { get; set; }
      public  double RegraSaldo(double saldo){
        Saldo = saldo;
        if(saldo < 0) { 
             throw new ArgumentException("Error: Não é possivel ter um saldo com esse valor");
            }
         return Saldo;
        }

   
     public void Teste() {
            Saldo = double.Parse(Console.ReadLine());
        }

        // precisa ser testado quando for realizar o sistema completo
        public void InformacaoTitutlar() {
            Console.WriteLine($"Nome do usuario: {NomeUsuario}");
            Console.WriteLine($"Idade Usuario: {IdadeUsuario}");
            Console.WriteLine($"Saldo: {Saldo} ");
        }
    }
}
