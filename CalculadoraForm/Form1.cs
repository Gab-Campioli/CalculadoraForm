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

        }

        private void numero_Click(object sender, EventArgs e)
        {
            // Obter o botão que esta chamando esse evento

            Button botaoClicado = (Button)sender;

            // Adicionar o Text do botão clicado no TextBox

            txbTela.Text += botaoClicado.Text;

            // Abaixar a bandeirinha

            operadorClicado = false;
        }

        private void operador_Click(object sender, EventArgs e)
        {
            // Verificar se o operador ainda nao foi clicado
            if (operadorClicado == false)
            {

                // Obter o botão que esta chamando esse evento

                Button botaoClicado = (Button)sender;

                // Adicionar o Text do botão clicado no TextBox

                txbTela.Text += botaoClicado.Text;

                // Levantar a bandeirinha

                operadorClicado = true;
            }
        }
    }
}
