using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        // Variáveis globais (Qualquer variavel declarada aqui pode ser utilizada em qualquer lugar)

        bool operadorClicado = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Para depois

            DataTable dt = new DataTable();
            try
            {
                var v = dt.Compute(txbTela.Text, "");
                txbTela.Text = v.ToString();

                if (txbTela.Text == "∞")
                {
                    btnLimpar.PerformClick();
                    MessageBox.Show("Não é possível dividir por 0!", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("Algo deu errado!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void numero_Click(object sender, EventArgs e)
        {

            Button botaoClicado = (Button)sender; // Obter o botão que esta chamando esse evento

            txbTela.Text += botaoClicado.Text; // Adicionar o Text do botão clicado no TextBox

            operadorClicado = false; // Abaixar a bandeirinha
        }

        private void operador_Click(object sender, EventArgs e)
        {
            // Verificar se o operador ainda nao foi clicado
            if (operadorClicado == false)
            {

                Button botaoClicado = (Button)sender; // Obter o botão que esta chamando esse evento

                txbTela.Text += botaoClicado.Text; // Adicionar o Text do botão clicado no TextBox

                // Levantar a bandeirinha

                operadorClicado = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a tela:

            txbTela.Text = "";

            // Voltar o operador clicado para true:
            operadorClicado = true;
        }
    }
}
