using System;

namespace Prova1
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoImportado carroImportado = new VeiculoImportado("CarroImportado", "Marca", 1000, 2018);
            VeiculoNacional carroNacional = new VeiculoNacional("CarroNacional", "Marca", 2000, 2018);
            Concessionaria concessionaria = new Concessionaria("Local", "Gerente", 2020);

            carroImportado.definirValorVeiculo(carroImportado.Valor);
            carroNacional.definirValorVeiculo(carroNacional.Valor);

            concessionaria.AdicionarCarro(carroNacional);
            concessionaria.AdicionarCarro(carroImportado);

            Console.WriteLine(carroNacional.GetType().Name);

            Console.Write($"Marca Do Carro:{carroNacional.Marca}, Ano De Fabricação{carroNacional.AnoFabricacao},\n+ Cor:{carroNacional.Cor},Valor:{carroNacional.Valor}");
            Console.WriteLine("\n");

            Console.WriteLine(carroImportado.GetType().Name);
            Console.Write($"Marca Do Carro:{carroImportado.Marca}, Ano De Fabricação{carroImportado.AnoFabricacao},Cor:{carroImportado.Cor},Valor:{carroImportado.Valor}");

            Console.WriteLine("\n");
            double valorPortifolio = concessionaria.CalcularPortifolio();
            Console.WriteLine($"Valor do Portifolio: {valorPortifolio}");

            
        }
    }
}
