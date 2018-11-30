using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aspNetVS2017.Capitulo01.Frete
{
    public partial class freteForm : Form
    {
        public freteForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {

            var erros = ValidarFormulario();

            if (erros.Count == 0)
            //if (ValidarFormulario())
            {
                Calcular();
            }

            else
            {

                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)                ;
                                
            }
        }

        private void Calcular()
        {
            var percentual = 0m;
            var valor = Convert.ToDecimal(valorTextBox.Text);
            var nordeste = new List<String> {"BA", "PE", "AL" };


            switch (ufComboBox.Text.ToUpper())

            {
                case "SP":
                    percentual = 0.2m;
                    break;

                case "RJ":
                case "ES":
                    percentual = 0.3m;
                    break;

                case "MG":
                    percentual = 0.35m;
                    break;

                case "AM":
                    percentual = 0.6m;
                    break;


                case var uf when nordeste.Contains(uf):
                    percentual = 0.45m;
                    break;

                case null:
                    throw new NullReferenceException("ComboBox Nulo");
                    
                default:
                    percentual = 0.5m;
                    break;
                    
            }


            freteTextBox.Text = percentual.ToString("P1");
            totalTextbox.Text = (valor * (1 + percentual)).ToString("C2");







        }


        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();


            if (string.IsNullOrEmpty(clienteTextBox.Text))
            {
                erros.Add("O campo cliente é obrigatório.");
                
            }

            if (ufComboBox.SelectedIndex == -1)
            {

                erros.Add("Selecione uma UF.");

            }

            if (valorTextBox.Text == string.Empty)
            {

                erros.Add("O campo valor é obrigatório");

            }
            else
            {

                if (!decimal.TryParse(valorTextBox.Text, out decimal valor))
                                
                {
                    erros.Add("O campo valor está com formato inválido");


                }

            }



            return erros;
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            clienteTextBox.Text = string.Empty;
            valorTextBox.Text = null;
            freteTextBox.Clear();
            totalTextbox.Text = "";
            ufComboBox.SelectedIndex = -1;

            clienteTextBox.Focus();

            //this.Close();


        }
    }
}
