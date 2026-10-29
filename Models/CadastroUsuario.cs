using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Compra_venda.Models {
    public class CadastroUsuario {
        public string? NomeUsuario { get; set; }
        public int IdadeUsuario {  get; set; }
        public int PerfilInvestidor { get; set; }
        public string GetNome(string nomeUsuario){
            NomeUsuario = nomeUsuario;
            if (string.IsNullOrEmpty(NomeUsuario)){
               throw new ArgumentNullException("Error: Insira alguma coisa para o progama funcionar");
            }
            return nomeUsuario;
        }
          public int GetIdade(int idade) {
            IdadeUsuario = idade;
            if (IdadeUsuario < 18 || IdadeUsuario > 99){
               throw new ArgumentException("Error: Idade inválida. Tente novamente");
            }
            
            return IdadeUsuario;
        }

        public int GetPerfil(int perfilInvestidor){
            PerfilInvestidor = perfilInvestidor;
            if (PerfilInvestidor <= 0 || PerfilInvestidor >= 4) { 
            throw new ArgumentException("Error: opção ivalida. Insira a informação de acordo com o que pede");
            }
            return PerfilInvestidor;
        }
     

    }
}
