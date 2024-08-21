using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_corrida
{
    internal class Pessoa
    {
        public string Nome;
        public Aposta MinhaAposta;
        public int Carteira;
        public RadioButton MeuradioButton;
        public Label MeuLabel;

        public void AtualizarLabel()
        {
            MeuradioButton.Text = Nome + " Tem " + Carteira + " Reais";
        }
        public void LimparAposta()
        {
            MeuLabel.Text = "Não houve nenhuma aposta do " + Nome;
            MinhaAposta.Valor = 0;
        }
        
        public bool Apostar(int Quantidade, int Cachorro)
        {
            Quantidade = this.MinhaAposta.Valor;
            Cachorro = this.MinhaAposta.Cachorro;
            if(Quantidade > Carteira)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Coletar(int Vencedor)
        {
            MessageBox.Show("O cachorro vencedor é o número " + Vencedor, " Cachorro Vencedor");
        }
    }
}
