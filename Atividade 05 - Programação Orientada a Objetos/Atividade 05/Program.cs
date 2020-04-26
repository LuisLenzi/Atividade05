using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n   Atividade 05 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
            Console.Write("\n\n   [Pessoa]");
            Pessoa A = new Pessoa("Luís Gustavo C. Lenzi", "Rua Sérgio Lenzi, 41 - Novo Horizonte - Monsenhor Paulo/MG", "(35) 99974-4769");
            Console.Write("\n   Nome: " + A.Nome + "\n   Endereço: " + A.End + "\n   Telefone: " + A.Tel);

            Fornecedor B = new Fornecedor("Via Brasil Distribuidora LTDA", "Rua Sérgio Lenzi, 10 - Novo Horizonte - Monsenhor Paulo/MG", "(35) 3263-1320");
            B.Valor_Credito = 4500000.00;
            B.Valor_Divida = 100000.00;
            Console.Write("\n\n   [Fornecedor]\n   Nome: " + B.Nome + "\n   Endereço: " + B.End + "\n   Telefone: " + B.Tel + "\n   > Saldo = R$ " + B.Saldo());

            Colaborador C = new Colaborador("Victor de Oliveira Bento", "Rua Luzia Teixeira, 276 - Residencial MGM - Monsenhor Paulo/MG", "(35) 99487-7845");
            C.ID_Setor = 1;
            C.Salario_Base = 13600.00;
            C.Impostos = 2;
            Console.Write("\n\n   [Colaborador]\n   Nome: " + C.Nome + "\n   Endereço: " + C.End + "\n   Telefone: " + C.Tel + "\n   > Saldo = R$ " + C.Salario());

            Administrador D = new Administrador("Marlão da Massa", "Varginha/MG", "(35) 3222-9204");
            D.ID_Setor = 2;
            D.Salario_Base = 15000.00;
            D.Impostos = 2;
            D.AjudaCusto = 450;
            Console.Write("\n\n   [Administrador]\n   Nome: " + D.Nome + "\n   Endereço: " + D.End + "\n   Telefone: " + D.Tel + "\n   > Saldo = R$ " + D.Salario());

            Operador E = new Operador("Adamo Bellato", "Avenida Atílio Bellato, 475 - Santa Cruz - Monsenhor Paulo/MG", "(35) 3263-2900");
            E.ID_Setor = 3;
            E.Salario_Base = 1000.00;
            E.Impostos = 2;
            E.Valor_Producao = 150.00;
            E.Comissao = 2;
            Console.Write("\n\n   [Operador]\n   Nome: " + E.Nome + "\n   Endereço: " + E.End + "\n   Telefone: " + E.Tel + "\n   > Saldo = R$ " + E.Salario());

            Vendedor F = new Vendedor("Alexandre Bellato Lenzi", "Rua Sérgio Lenzi, 41 - Novo Horizonte - Monsenhor Paulo/MG", "(35) 99974-4769");
            F.ID_Setor = 4;
            F.Salario_Base = 8000.00;
            F.Impostos = 2;
            F.Valor_Vendas = 100000.00;
            F.Comissao = 8;
            Console.Write("\n\n   [Vendedor]\n   Nome: " + F.Nome + "\n   Endereço: " + F.End + "\n   Telefone: " + F.Tel + "\n   > Saldo = R$ " + F.Salario());
            Console.ReadKey();
        }
    }
}
