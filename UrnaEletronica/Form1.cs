using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        private int votoCiro = 0;
        private int votoMarina = 0;
        private int votoBolsonaro = 0;
        private int votoHaddad = 0;
        private int votoAlckmin = 0;
        private int votoNulo = 0;
        private int votoBranco = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Number(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Number(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Number(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Number(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Number(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Number(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Number(0);
        }

        private void Number(int numero)
        {
            textBox1.Text = textBox1.Text + numero;

            string text = textBox1.Text;
            if (text.Length > 2) { text = text.Substring(0, 2); }
            if (text.Length == 2) { AtualizaFoto(text); }
            textBox1.Text = text;
        }

        private void AtualizaFoto(string candidato)
        {
            switch (candidato)
            {
                case "12": pictureBox1.Image = Properties.Resources.cirogomes; break;
                case "18": pictureBox1.Image = Properties.Resources.marinasilva; break;
                case "17": pictureBox1.Image = Properties.Resources.jairbolsonaro; break;
                case "13": pictureBox1.Image = Properties.Resources.fernadohaddad; break;
                case "45": pictureBox1.Image = Properties.Resources.geraldoalckmin; break;
                case "00": pictureBox1.Image = Properties.Resources.votonulo; break;
                case "": pictureBox1.Image = null; break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            pictureBox1.Image.Dispose();
            pictureBox1.Image = Properties.Resources.eleitoral;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "12": votoCiro++; break;
                case "18": votoMarina++; break;
                case "17": votoBolsonaro++; break;
                case "13": votoHaddad++; break;
                case "45": votoAlckmin++; break;
                case "00": votoNulo++; break;
            }

            MessageBox.Show("Fim");
            textBox1.Text = string.Empty;
            pictureBox1.Image = Properties.Resources.eleitoral;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "": votoBranco++; break;
            }

            MessageBox.Show("Fim");
            textBox1.Text = string.Empty;
            pictureBox1.Image = Properties.Resources.eleitoral;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string texto = "";

            texto = "\nQuantidade de votos: Ciro: " + votoCiro;
            texto += "\nQuantidade de votos: Marina: " + votoMarina;
            texto += "\nQuantidade de votos: Bolsonaro: " + votoBolsonaro;
            texto += "\nQuantidade de votos: Haddad: " + votoHaddad;
            texto += "\nQuantidade de votos: Alckmin: " + votoAlckmin;
            texto += "\nQuantidade de votos: Nulos: " + votoNulo;
            texto += "\nQuantidade de votos: Brancos: " + votoBranco;
            MessageBox.Show(texto);
        }
    }
}