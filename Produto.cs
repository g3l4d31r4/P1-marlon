using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_marlon
{
    class Produto
    {
        private string Nome;
        private string propriedade;
        private double Preço;

        public void SetNome(string n)
        {
            Nome = n;
        }
        public void SetPreço(double pr)
        {
            Preço = pr;
        }

       
        public static double CalculoTotal(int qtd, double valor)
        {
            return qtd * valor;

        }

    }
}
