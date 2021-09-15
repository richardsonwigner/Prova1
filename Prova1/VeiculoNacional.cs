using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    class VeiculoNacional : Veiculo
    {
        public VeiculoNacional() { }
        public VeiculoNacional(string cor, string marca, double valor, int anoFabricacao) : base(cor, marca, valor, anoFabricacao)
        {
        }
        public override void definirValorVeiculo(double custoFixo)
        {
            custoFixo = custoFixo * 1.5 + 0.2 * custoFixo + custoFixo / 10;
            valor += custoFixo;
        }
    }
}
