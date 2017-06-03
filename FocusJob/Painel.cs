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
    public partial class Painel : Form
    {
        public int cTotal;
        int i=15;//variavel para cronometrar o timer2(utilizado apenas para o descanso);
        public int pomTotal = 0;//armazena a quantidade total de pomodoris para fazer a pausa;
        Atividade ativAtual;
        public int cont = 0;//contador para o timer;
        public int pom;//pega a quantidade de pomodoris do outro Form;
        public int mostraPom = 1;//Conta o pomodori que está atualmente;
        public int limitePom; //limita a quantidade de pomodoris daquela atividade;
        int nAtividade = 0;
        Atividade[] vetor;
        public int contagem;
        public void pegaVetor(Atividade[] vetor)
        {
            this.vetor = vetor;
        }
        public void descansar(int tempo)
        {
            i = tempo;
            lblDescanso.Text = Convert.ToString(i)+" minutos";
            lblDescanso.Visible = true;
            lblD.Visible = true;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.lblAtivAtual.Visible = false;
            this.lblPomodori.Visible = false;
            this.lblTempo.Visible = false;
            timer2.Start();
            
        }
        public void desdescansar()
        {
            lblDescanso.Visible = false;
            lblD.Visible = false;
           // i = 15;
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.lblAtivAtual.Visible = true;
            this.lblPomodori.Visible = true;
            this.lblTempo.Visible = true;
           // timer2.Stop();
        }



        public void pegaAtividade()
        {
            ativAtual = vetor[nAtividade];
            lblPomodori.Text = Convert.ToString(mostraPom) + "/" + ativAtual.qtdPomodoris;
            lblAtivAtual.Text = ativAtual.nome;
            limitePom = vetor[nAtividade].qtdPomodoris;
        }
        public void zeraPom()
        {
            lblPomodori.Text = "1/"+ativAtual.qtdPomodoris;
            //pomTotal += mostraPom;
            mostraPom = 1;
        }

        public Painel()
        {
            InitializeComponent();
        }

        private void Painel_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont = pom * 25;
            cTotal = cont;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (cont >= 0)
            {
                lblTempo.Text = Convert.ToString(cont)+ " minutos .";
                cont--;
                if ((cont+1) % 25 == 0 && cont!=0 && cont+1!=cTotal)
                {
                    mostraPom++;

                    pomTotal++;
                    timer1.Stop();
                    descansar(5);
                    if (cont>0)
                    lblPomodori.Text = Convert.ToString(mostraPom)+"/"+ativAtual.qtdPomodoris;
                    if (pomTotal%4==0)
                    {
                       
                        timer1.Stop();
                        descansar(15);
                       
                       //Criar uma label para acompanhar a variavel pomTotal e implementar o método de descanso de 5 minutos;                
                    
                    }
                }
                if (mostraPom > ativAtual.qtdPomodoris && cont>0)
                {
                    nAtividade++;
                    pegaAtividade();
                    zeraPom();
                }
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i--;
            lblDescanso.Text = Convert.ToString(i) + " minutos";
           

            if (i == -1)
            {
                timer2.Stop();
                desdescansar();
                timer1.Start();
            }
        }
    }
}
