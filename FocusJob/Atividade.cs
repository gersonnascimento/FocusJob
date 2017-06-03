using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusJob
{
    public class Atividade
    {
       public int qtdPomodoris;
       public string nome;

        public Atividade(int qtd, string nome)
        {
            this.qtdPomodoris = qtd;
            this.nome = nome;
        }
    }
}
