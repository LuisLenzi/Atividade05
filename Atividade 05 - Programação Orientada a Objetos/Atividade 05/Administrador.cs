using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_05
{
    class Administrador : Colaborador
    {
        private double ajudacusto;
        public Administrador(string Nome, string End, string Tel):base(Nome,End,Tel)
        { }
        public double AjudaCusto
        {
            get { return ajudacusto; }
            set { ajudacusto = value; }
        }
        public override double Salario()
        {
            return base.Salario() + AjudaCusto;
        }
    }
}
