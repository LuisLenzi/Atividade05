using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_05
{
    class Vendedor : Colaborador
    {
        private double valor_vendas;
        private int comissao;

        public Vendedor(string Nome, string End, string Tel):base(Nome, End, Tel)
        { }
        public double Valor_Vendas
        {
            get { return valor_vendas; }
            set { valor_vendas = value; }
        }
        public int Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }
        public override double Salario()
        {
            double Valor_Comissao = Valor_Vendas - (Valor_Vendas * ((double)Comissao / 100));
            return base.Salario() + Valor_Comissao;
        }
    }
}
