using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_corrida
{
    public partial class Form1 : Form
    {
        Cachorro Cachorro1;
        Cachorro Cachorro2;
        Cachorro Cachorro3;
        Cachorro Cachorro4;
        Pessoa PessoaJoao;
        Pessoa PessoaBeto;
        Pessoa PessoaAlfredo;
        Aposta ApJoao;
        Aposta ApBeto;
        Aposta ApAlfredo;
        public bool vencedor;
        public bool aposta1;
        public bool aposta2;
        public bool aposta3;
        public Form1()
        {
            InitializeComponent();
            Cachorro1 = new Cachorro();
            Cachorro2 = new Cachorro();
            Cachorro3 = new Cachorro();
            Cachorro4 = new Cachorro();

            Cachorro1.MypictureBox = img1;
            Cachorro2.MypictureBox = img2;
            Cachorro3.MypictureBox = img3;
            Cachorro4.MypictureBox = img4;

            PessoaJoao = new Pessoa() { Nome = "João", Carteira = 50, MeuLabel = label5, MeuradioButton = radioButton1 };
            PessoaBeto = new Pessoa() { Nome = "Beto", Carteira = 75, MeuLabel = label6, MeuradioButton = radioButton2 };
            PessoaAlfredo = new Pessoa() { Nome = "Alfredo", Carteira = 45, MeuLabel = label7, MeuradioButton = radioButton3 };

            ApJoao = new Aposta();
            ApBeto = new Aposta();
            ApAlfredo = new Aposta();

            PessoaJoao.MinhaAposta = ApJoao;
            PessoaBeto.MinhaAposta = ApBeto;
            PessoaAlfredo.MinhaAposta = ApAlfredo;

            ApJoao.Apostador = PessoaJoao;
            ApBeto.Apostador = PessoaBeto;
            ApAlfredo.Apostador = PessoaAlfredo;

            PessoaJoao.LimparAposta();
            PessoaBeto.LimparAposta();
            PessoaAlfredo.LimparAposta();

            PessoaJoao.AtualizarLabel();
            PessoaBeto.AtualizarLabel();
            PessoaAlfredo.AtualizarLabel();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked = true)
            {
                ApJoao.Valor = Convert.ToInt32(numericUpDown1.Value);
                ApJoao.Cachorro = Convert.ToInt32(numericUpDown2.Value);
                if (PessoaJoao.Carteira >= ApJoao.Valor)
                {
                    aposta1 = true;
                    radioButton1.Enabled = false;
                    radioButton1.Checked = false;
                    ApJoao.PegarDesc();
                    PessoaJoao.Carteira -= ApJoao.Valor;
                    PessoaJoao.AtualizarLabel();
                }
                else
                {
                    MessageBox.Show("Você não tem dinheiro o bastante para a aposta", "Alerta");
                    ApJoao.Valor = 0;
                }
            }

            if (radioButton2.Checked = true)
            {
                ApBeto.Valor = Convert.ToInt32(numericUpDown1.Value);
                ApBeto.Cachorro = Convert.ToInt32(numericUpDown2.Value);
                if (PessoaBeto.Carteira >= ApBeto.Valor)
                {
                    aposta2 = true;
                    radioButton2.Enabled = false;
                    radioButton2.Checked = false;
                    ApBeto.PegarDesc();
                    PessoaBeto.Carteira -= ApBeto.Valor;
                    PessoaBeto.AtualizarLabel();
                }
                else
                {
                    MessageBox.Show("Você não tem dinheiro o bastante para a aposta", "Alerta");
                    ApBeto.Valor = 0;
                }
            }
        } 
            

        private void button2_Click(object sender, EventArgs e)
        {
            int Primeiro;
            button1.Enabled = false;
            button2.Enabled = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;

            while (Cachorro1.Correr() == false && Cachorro2.Correr() == false && Cachorro3.Correr() == false && Cachorro4.Correr() == false)
            {
                Application.DoEvents(); //Função para não travar o formulário
                System.Threading.Thread.Sleep(1); /// tempo de 1 milessegundo
            }
            if (Cachorro1.Correr() == true)
            {
                Primeiro = 1;
                this.PessoaJoao.Coletar(Primeiro);
                button1.Enabled = true;
                button2.Enabled = true;
                if (aposta1 == true && ApJoao.Cachorro == Primeiro)
                {
                    PessoaJoao.Carteira += 2 * ApJoao.Valor;
                }

                if (aposta2 == true && ApBeto.Cachorro == Primeiro)
                {
                    PessoaBeto.Carteira += 2 * ApBeto.Valor;
                }

                if (aposta3 == true && ApAlfredo.Cachorro == Primeiro)
                {
                    PessoaAlfredo.Carteira += 2 * ApAlfredo.Valor;
                }
            }
            else if (Cachorro2.Correr() == true)
            {
                Primeiro = 2;
                this.PessoaJoao.Coletar(Primeiro);
                button1.Enabled = true;
                button2.Enabled = true;
                if (aposta1 == true && ApJoao.Cachorro == Primeiro)
                {
                    PessoaJoao.Carteira += 2 * ApJoao.Valor;
                }

                if (aposta2 == true && ApBeto.Cachorro == Primeiro)
                {
                    PessoaBeto.Carteira += 2 * ApBeto.Valor;
                }

                if (aposta3 == true && ApAlfredo.Cachorro == Primeiro)
                {
                    PessoaAlfredo.Carteira += 2 * ApAlfredo.Valor;
                }
            }
            else if (Cachorro3.Correr() == true)
            {
                Primeiro = 3;
                this.PessoaJoao.Coletar(Primeiro);
                button1.Enabled = true;
                button2.Enabled = true;
                if (aposta1 == true && ApJoao.Cachorro == Primeiro)
                {
                    PessoaJoao.Carteira += 2 * ApJoao.Valor;
                }

                if (aposta2 == true && ApBeto.Cachorro == Primeiro)
                {
                    PessoaBeto.Carteira += 2 * ApBeto.Valor;
                }

                if (aposta3 == true && ApAlfredo.Cachorro == Primeiro)
                {
                    PessoaAlfredo.Carteira += 2 * ApAlfredo.Valor;
                }
            }
            else if (Cachorro4.Correr() == true)
            {
                Primeiro = 4;
                this.PessoaJoao.Coletar(Primeiro);
                button1.Enabled = true;
                button2.Enabled = true;
                if (aposta1 == true && ApJoao.Cachorro == Primeiro)
                {
                    PessoaJoao.Carteira += 2 * ApJoao.Valor;
                }

                if (aposta2 == true && ApBeto.Cachorro == Primeiro)
                {
                    PessoaBeto.Carteira += 2 * ApBeto.Valor;
                }

                if (aposta3 == true && ApAlfredo.Cachorro == Primeiro)
                {
                    PessoaAlfredo.Carteira += 2 * ApAlfredo.Valor;
                }
            }

            PessoaJoao.AtualizarLabel();
            PessoaBeto.AtualizarLabel();
            PessoaAlfredo.AtualizarLabel();

            Cachorro1.VoltarInicio();
            Cachorro2.VoltarInicio();
            Cachorro3.VoltarInicio();
            Cachorro4.VoltarInicio();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;

            aposta1 = false;
            aposta2 = false;
            aposta3 = false;

            PessoaJoao.LimparAposta();
            PessoaBeto.LimparAposta();
            PessoaAlfredo.LimparAposta();

            if(PessoaJoao.Carteira == 0)
            {
                PessoaJoao.MeuradioButton.Enabled = false;
            }

            if (PessoaBeto.Carteira == 0)
            {
                PessoaBeto.MeuradioButton.Enabled = false;
            }

            if (PessoaAlfredo.Carteira == 0)
            {
                PessoaAlfredo.MeuradioButton.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = PessoaJoao.Nome;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = PessoaBeto.Nome;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = PessoaAlfredo.Nome;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label2.Text = PessoaJoao.Nome;
            if (PessoaJoao.Carteira < 5)
            {
                numericUpDown1.Minimum = 0;
            }
            else
            {
                numericUpDown1.Minimum = 5;
            }
            if (PessoaJoao.Carteira < 15)
            {
                numericUpDown1.Maximum = PessoaJoao.Carteira;
            }
            else
            {
                numericUpDown1.Maximum = 15;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label2.Text = PessoaBeto.Nome;
            if (PessoaBeto.Carteira < 5)
            {
                numericUpDown1.Minimum = 0;
            }
            else
            {
                numericUpDown1.Minimum = 5;
            }
            if (PessoaBeto.Carteira < 15)
            {
                numericUpDown1.Maximum = PessoaBeto.Carteira;
            }
            else
            {
                numericUpDown1.Maximum = 15;
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            label2.Text = PessoaAlfredo.Nome;
            if (PessoaAlfredo.Carteira < 5)
            {
                numericUpDown1.Minimum = 0;
            }
            else
            {
                numericUpDown1.Minimum = 5;
            }
            if (PessoaAlfredo.Carteira < 15)
            {
                numericUpDown1.Maximum = PessoaAlfredo.Carteira;
            }
            else
            {
                numericUpDown1.Maximum = 15;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Simulador feito por:\n Felipe Toffetti\nGitHub:\nhttps://github.com/toffettl");
        }
    }
}