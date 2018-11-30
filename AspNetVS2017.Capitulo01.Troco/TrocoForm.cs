﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {

            //decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            //decimal valorPago = Convert.ToDecimal(valorPagoTextBox.Text);

            var valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            var valorPago = Convert.ToDecimal(valorPagoTextBox.Text);

            var troco = valorPago - valorCompra;

            trocoTextBox.Text = troco.ToString("C2");

            var moedas = new decimal[] { 1, 0.5m, 0.25m, 0.1m, 0.05m, 0.01m };


            for (int i = 0; i < moedas.Length; i++)
            {
                moedaListView.Items[i].Text = ((int)(troco / moedas[i])).ToString();
                troco %= moedas[i];
            }


            //ToDo. refatorar para usar vetor com foreach

            //var moedas1 = (int)(troco/1); //todo se usar o convert, arredonda para mais ou menos, usando o (int) que significa CAST extrai a parte inteira do numero decimal
            //troco = troco % 1;

            //var moedas050 = (int)(troco / 0.5m);
            //troco = troco % 0.5m;

            //var moedas025 = (int)(troco / 0.25m);
            //troco = troco % 0.25m;

            //var moedas010 = (int)(troco / 0.1m);
            //troco = troco % 0.1m;

            //var moedas005 = (int)(troco / 0.05m);
            //troco = troco % 0.05m;

            //var moedas001 = (int)(troco / 0.01m);
            //troco = troco % 0.01m;

            //moedaListView.Items[0].Text = moedas1.ToString();
            //moedaListView.Items[1].Text = moedas050.ToString();
            //moedaListView.Items[2].Text = moedas025.ToString();
            //moedaListView.Items[3].Text = moedas010.ToString();
            //moedaListView.Items[4].Text = moedas005.ToString();
            //moedaListView.Items[5].Text = moedas001.ToString();










        }

        private void TrocoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
