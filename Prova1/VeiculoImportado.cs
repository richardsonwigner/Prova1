using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    class VeiculoImportado : Veiculo
    {
        public VeiculoImportado() { }
        public VeiculoImportado(string cor, string marca, double valor, int anoFabricacao) : base(cor, marca, valor, anoFabricacao)
        { 
        }
        public override void definirValorVeiculo(double custoFixo)
        {
            custoFixo = custoFixo * 3.0 + 0.6 * custoFixo + custoFixo / 5;
            valor += custoFixo;          
        }

    }
}
