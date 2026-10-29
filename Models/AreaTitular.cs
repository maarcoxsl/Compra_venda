using System;
using System.Collections.Generic;
using System.Text;

namespace Compra_venda.Models {
    // get  == leitura
    // set == alterar valor
    // Nome
    // Perfil
    public class AreaTitular : CadastroUsuario {
      
      public double Saldo { get; set; }
      public  double RegraSaldo(double saldo){
        Saldo = saldo;
        if(saldo < 0) { 
             throw new ArgumentException("Error: Não é possivel ter um saldo com esse valor");

            }
        
         return Saldo;
        }
    }
}
