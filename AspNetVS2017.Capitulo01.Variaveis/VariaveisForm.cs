﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int x = 32;
        int w = 45;
        int y = 16;
        int z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6, c = 10;
            int d = 13;

            //d = "44";

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add(string.Concat("b = ", b));
            resultadoListBox.Items.Add(string.Format("c = {0}", c));//o argumento {0} indica a primeira variável, no caso o "c"
            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add("-------------------------");

            resultadoListBox.Items.Add("c * d = " + (c * d));
            resultadoListBox.Items.Add("c / d = " + (c / d));
            resultadoListBox.Items.Add("d % a = " + (d % a));// o sinal % significa modulo

            ////int a = 35;
            //int meuInteiro = 10;
            //decimal valor = 22.39m;
            //string nome = "Vítor";
            //bool aprovado = true;
            //var dataNascimento = new DateTime(1970, 12, 25);
            //int f = 17;
            //var sobrenome = "Avelino";
            ////var nota;
            ////if (nota > 7)
            ////{

            ////}
            //var @decimal = 0.2m;
            //object meuObjeto = 45;
            //meuObjeto = "Vítor";
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;

            resultadoListBox.Items.Add("x = " + x);

            //x = x - 3;
            x -= 3;

            resultadoListBox.Items.Add("x = " + x);
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;

            a = 5;
            resultadoListBox.Items.Add("Exemplo Pré-Incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + ++a = " + (2 + ++a)); // os sinais ++ indicam soma de mais 1, 2 + 6, aqui está antes do a então acrescenta ao a antes de somar ao 2

            a = 5;
            resultadoListBox.Items.Add("Exemplo Pós-Incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + a++ = " + (2 + a++));// aqui, os sinais ++ estão depois do a logo, o 2 soma ao a e só depois soma 1 ao a. 2 + 5. na proxima vez que chamar o a, ele valerá 6
            resultadoListBox.Items.Add("a = " + a);
        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (true)
            //{
            //    var j = 22;
            //}
            //j = 11;

            ApresentarVariaveis();

            resultadoListBox.Items.Add("w <= x = " + (w <= x));
            resultadoListBox.Items.Add("x == z = " + (x == z));
            resultadoListBox.Items.Add("x != z = " + (x != z));
        }

        private void ApresentarVariaveis()
        {
            resultadoListBox.Items.Add("x = " + x);
            resultadoListBox.Items.Add("w = " + w);
            resultadoListBox.Items.Add("y = " + y);
            resultadoListBox.Items.Add("z = " + z);

            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApresentarVariaveis();

            resultadoListBox.Items.Add("w <= x || y == 16 = " + (w <= x || y == 16)); // Os sinais || significa "OU"
            resultadoListBox.Items.Add("x == z && x != z = " + (x == z && x != z)); // Os sinais && significa "AND"
            resultadoListBox.Items.Add("!(y > w) = " + !(y > w)); // Colocando a exclamação, indica negação ou seja,  não é ......
        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2014;
            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}.", ano,
                ano % 4 == 0 ? "Sim" : "Não"));

            ano = 2016;
            resultadoListBox.Items.Add(
                $"O ano {ano} é bissexto? {(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}.");
        }
    }
}
