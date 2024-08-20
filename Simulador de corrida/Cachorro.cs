using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Simulador_de_corrida
{
    public class Cachorro
    {
        public int LocalInicial = 33;
        public int TamanhoPista = 720;
        public PictureBox MypictureBox = null;
        public int local = 0;
        public Random Random;

        public bool Correr()
        {
            int correu;
            Random = new Random();

            correu = Random.Next(0, 10);
            correu = (correu * Random.Next(0, 2)) % 5;
            correu = (correu * Convert.ToInt32(System.DateTime.Now.Millisecond) % 50); //gerar um número aletatório com baser nos milessegundos atuais para não repetir sequencias
            correu = (correu % 10) + 1; //Alterar a % altera a velocidade dos cachorros
            System.Threading.Thread.Sleep((Convert.ToInt32(System.DateTime.Now.Millisecond) % 8));

            Point p = MypictureBox.Location;
            p.X += correu;

            MypictureBox.Location = p;
            if(p.X >= TamanhoPista)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   
        public void VoltarInicio()
        {
            Point p = this.MypictureBox.Location; // o "this" serve apenas para localizar mais facil o objeto, não é obrigatório
            p.X = LocalInicial;
            this.MypictureBox.Location = p;
        }
        ///.
    }
}
