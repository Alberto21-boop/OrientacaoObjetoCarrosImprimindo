using System;

namespace app1110
{
    internal class Carro
    {
        public string NomeDoCarro { get; set; } = default!;
        public int NumeroDaPlaca { get; set; }
        public string CorDoCarro { get; set; } = default!;

        public string CarroNome()
        {
            return NomeDoCarro;
        }
        public int PlacaNumero()
        {
            return NumeroDaPlaca;
        }
        public string Cores()
        {
            return CorDoCarro;
        }
    }
}