using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado; // globais

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtNumero1.Text, out numero1))
            {
                errorProvider1.SetError(txtNumero1, "Número 1 inválido!"); //Componento que cria um símbolo vermelho de erro no componente e ao passar o mouse por cima exibe a mensagem
                txtNumero1.Focus(); // Obriga o usuário a voltar ao txtNumero1
            } else
            {
                errorProvider1.SetError(txtNumero1, ""); // Limpar o erro provider para não ficar aparecendo o erro quando der certo
            }
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            try
            {
                errorProvider2.SetError(txtNumero2, "");
                numero2 = Convert.ToDouble(txtNumero2.Text);
            } 
            catch
            {
                errorProvider2.SetError(txtNumero2, "Número 2 inválido!");
                txtNumero2.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resultado = numero1 + numero2;
            txtResultado.Text = resultado.ToString("N"); // N e G servem para controlar a exibição das casas
                                                         // N2 e G2 colocam 2 casas decimais
                                                         // Enquanto N coloca ponto para separar centena, milhar, milhão e etc, G não coloca nada
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            resultado = numero1 - numero2;
            txtResultado.Text = resultado.ToString("N");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString("N");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if(numero2 == 0)
            {
                MessageBox.Show("Denominador inválido! O divisor deve ser diferente de 0.");
                txtNumero2.Focus();
            } else
            {
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString("N");
            }
        }

        private void btnFatorialNum1_Click(object sender, EventArgs e)
        {
            resultado = 1;
            for(int i = 1; i <= numero1; i++)
            {
                resultado = resultado * i;
            }
            txtResultado.Text = resultado.ToString("N");
        }

        private void btnFatorialNum2_Click(object sender, EventArgs e)
        {
            resultado = 1;
            for (int i = 1; i <= numero2; i++)
            {
                resultado = resultado * i;
            }
            txtResultado.Text = resultado.ToString("N");
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            resultado = 1;
            for(int i = 1;i <= numero2;i++)
            {
                resultado = resultado * numero1;
            }
            txtResultado.Text= resultado.ToString("N");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear(); 
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja sair mesmo?", "Saída", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                // Segundo "componente" (Saida) = Título
            {
                Close();
            }
        }

    }
}
