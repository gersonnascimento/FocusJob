using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusJob
{
    public partial class Form1 : Form
    {
        int atv = 1;
        int pom = 0;
        Atividade[] vet = new Atividade[20];
        int contagem = 0;//conta as atividades inclusas pelo usuário;
        public bool vazio()
        {
            if (this.txtAtividade.Text == "" || this.cmbQtd.Text == "")
                return true;
            else return false;
        }
        public void limpaTxt()
        {
            this.txtAtividade.Text = "";
            this.cmbQtd.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vazio())
            {
                MessageBox.Show("Preencha todas as informações solicitadas.");
            }
            else
            {
                vet[contagem] = new Atividade(Convert.ToInt16(this.cmbQtd.Text), this.txtAtividade.Text);
                contagem++;
                pom += Convert.ToInt16(cmbQtd.Text);
                limpaTxt();
                MessageBox.Show("Atividade " + atv + " Cadastrada!");
                atv++;
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Painel p = new Painel();
            p.pegaVetor(vet);
            p.contagem = this.contagem;
            p.pom = this.pom;
            p.pegaAtividade();
            Hide();
            p.Show();
        }

        private void txtAtividade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
