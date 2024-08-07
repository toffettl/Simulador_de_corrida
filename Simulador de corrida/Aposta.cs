 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_corrida
{
    internal class Aposta
    {
        public int Cachorro;
        public int Valor;
        public Pessoa Apostador;
        public string PegarDesc()
        {
            if(Apostador.Carteira >= Apostador.MinhaAposta.Valor)
                this.Apostador.MeuLabel.Text = this.Apostador.Nome + " apostou" + Valor + " reais no cachorro número" + Cachorro;
                return Apostador.MeuLabel.Text;
        }

        public int Pagar(int Vencedor)
        {
            return Valor;
        }
    }
}
