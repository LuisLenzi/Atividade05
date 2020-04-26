using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_05
{
    class Operador : Colaborador
    {
        private double valor_producao;
        private int comissao;

        public Operador(string Nome, string End, string Tel):base(Nome, End, Tel)
        { }
        public double Valor_Producao
        {
            get { return valor_producao; }
            set { valor_producao = value; }
        }
        public int Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }
        public override double Salario()
        {
            double Valor_Final = Valor_Producao - (Valor_Producao * ((double)Comissao / 100)); 
            return base.Salario() + Valor_Final;
        }
    }
}
