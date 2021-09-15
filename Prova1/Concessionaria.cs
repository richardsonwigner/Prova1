using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    class Concessionaria
    {
        protected string localizacao;
        protected string gerentePrincipal;
        protected int anoFundacao;
        protected List<Veiculo> carrosDisponiveis = new List<Veiculo>();

        public Concessionaria(string localizacao, string gerentePrincipal,  int anoFundacao)
        {
            this.localizacao = localizacao;
            this.gerentePrincipal = gerentePrincipal;
            this.anoFundacao = anoFundacao;
        }
        public void AdicionarCarro(Veiculo x)
        {
            carrosDisponiveis.Add(x);
        }
        public double CalcularPortifolio()
        {
            double valorTotal = 0;
            foreach(Veiculo carro in carrosDisponiveis)
            {
                valorTotal += carro.Valor;
            }
            return valorTotal;
        }

    }
}
