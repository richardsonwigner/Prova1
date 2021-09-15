using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    class Veiculo
    {
        protected string cor;
        protected string marca;
        protected double valor;
        protected int anoFabricacao;

        public Veiculo() { }
 
        public Veiculo(string cor, string marca, double valor, int anoFabricacao)
        {
            this.cor = cor;
            this.marca = marca;
            this.valor = valor;
            this.anoFabricacao = anoFabricacao;
        }
        public virtual void definirValorVeiculo(double custoFixo)
        {
            valor = +custoFixo;
        }
        public string Cor
        { get { return cor; }
          set { cor = value; }
        }
        public string Marca
        { get { return marca; }
          set { marca = value; }       
        }
        public double Valor
        { get { return valor; }
          set { valor = value; }  
        }
        public int AnoFabricacao
        { get { return anoFabricacao; }
          set { anoFabricacao = value; }
        }

    }
}
