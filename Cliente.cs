using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Projeto_marlon
{
    class Cliente
    {
        public string Nome;
        public string Endereço;

        private void ProdutoEscolhido(string nome, int quantidade)
        {
            Console.WriteLine("Produto >> {0} - Total >> {1}", nome, quantidade);
        }
            
                
        public void Pagar(int qtd, double valor)
        {
            Console.WriteLine(Produto.CalculoTotal(qtd, valor));
        }
    }
}