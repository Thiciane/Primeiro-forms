using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroForm
{
    public partial class telinha : Form
    {
        public telinha()
        {
            InitializeComponent();
            lb_diferentes.Text = "";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = mask_cpf.Text;
            string senha = tx_senha.Text;
            string confSenha = tx_confirmarSenha.Text;
            if(senha == confSenha)
            {
                string nome = tx_nome.Text;
                string email = tx_email.Text;
                MessageBox.Show(nome + " " + email);

            }
            else
            {
                lb_diferentes.ForeColor = Color.Red;
                lb_diferentes.Text = "Senhas diferentes!";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_email.Clear();
            tx_senha.Clear();
            mask_cpf.Clear();
            tx_confirmarSenha.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(BackColor == Color.Violet)
            {
                BackColor = Color.Gray;
                button1.BackColor = Color.Gray; button2.BackColor = Color.Gray; button3.BackColor = Color.Gray;
            }
            else if(BackColor == Color.Gray)
            {
                BackColor = Color.DarkOrange;
                button1.BackColor = Color.Orange; button2.BackColor = Color.Orange; button3.BackColor = Color.Orange;

            }
            else if(BackColor == Color.DarkOrange)
            {
                BackColor = Color.Violet;
                button1.BackColor = Color.LightPink; button2.BackColor = Color.LightPink; button3.BackColor = Color.LightPink;

            }
        }
    }
}
