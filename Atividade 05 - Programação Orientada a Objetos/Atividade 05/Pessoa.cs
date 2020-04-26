using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_05
{
    class Pessoa
    {
        private string nome;
        private string endereco;
        private string telefone;

        public Pessoa(string Nome, string End, string Tel)
        {
            this.nome = Nome;
            this.endereco = End;
            this.telefone = Tel;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string End
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Tel
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
