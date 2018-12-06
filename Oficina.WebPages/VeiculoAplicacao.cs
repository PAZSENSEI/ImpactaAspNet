using Oficina.Dominio;
using Oficina.Repositorios;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Oficina.WebPages
{
    public class VeiculoAplicacao
    {

        private readonly MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        private readonly ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        private readonly CorRepositorio corRepositorio = new CorRepositorio();
        private readonly VeiculoRepositorio veiculoRepositorio = new VeiculoRepositorio();

        public VeiculoAplicacao()
        {
            PopularControles();
        }

        public List<Marca> Marcas { get; private set; }
        public string MarcaSelecionada { get; set; }
        public List<Cor> Cores { get; private set; }
        public List<Combustivel> Combustiveis { get; private set; }
        public List<Cambio> Cambios { get; private set; }
        public List<Modelo> Modelos { get; private set; } = new List<Modelo>(); //campo nulo que é preenchido depois que seleciona outro campo

        private void PopularControles()
        {
            Marcas = marcaRepositorio.Selecionar();

            MarcaSelecionada = HttpContext.Current.Request.QueryString["marcaId"];
            if (!string.IsNullOrEmpty(MarcaSelecionada))
            {
                Modelos = modeloRepositorio.SelecionarPorMarca(Convert.ToInt32(MarcaSelecionada));
            }


            Cores = corRepositorio.Selecionar();
            Combustiveis = Enum
                .GetValues(typeof(Combustivel))
                .Cast<Combustivel>()
                .ToList();
            Cambios = Enum
                .GetValues(typeof(Cambio))
                .Cast<Cambio>()
                .ToList();
        }


        public void Inserir()
        {
            try
            {
                var veiculo = new VeiculoPasseio();
                var formulario = HttpContext.Current.Request.Form;

                veiculo.Ano = Convert.ToInt32(formulario["ano"]);
                veiculo.Cambio = (Cambio)Convert.ToInt32(formulario["cambio"]);
                veiculo.Combustivel = (Combustivel)Convert.ToInt32(formulario["combustivel"]);
                veiculo.Cor = corRepositorio.Selecionar(Convert.ToInt32(formulario["cor"]));
                veiculo.Modelo = modeloRepositorio.Selecionar(Convert.ToInt32(formulario["modelo"]));
                veiculo.Carroceria = Carroceria.Hatch;
                veiculo.Observacoes = formulario["observacao"];
                veiculo.Placa = formulario["placa"];/*.ToUpper();*/
                veiculoRepositorio.Inserir(veiculo);

                new VeiculoRepositorio().Inserir(veiculo);
            }
            catch (FileNotFoundException ex) when (!ex.FileName.Contains("Senha"))
            {
                
                HttpContext.Current.Items.Add("MensagemErro", $"Arquivo {ex.FileName} não encontrado.");

                throw;
            }

            catch (DirectoryNotFoundException)
            {
                HttpContext.Current.Items.Add("MensagemErro", $"Diretório não encontrado.");
                throw;
            }

            catch (UnauthorizedAccessException)
            {
                HttpContext.Current.Items.Add("MensagemErro", $"Acesso Negado.");
                throw;
            }

            catch (Exception)
            {
                HttpContext.Current.Items.Add("MensagemErro", $"Atenção, ocorreu um erro, acione o suporte");
                throw;
            }
            finally
            {
                //é sempre executado tanto no sucesso ou no erro
            }
            //    veiculo.Placa = "FTW-1836";
            //    veiculo.Observacao = "Observação";
            //    veiculo.Combustivel = Combustivel.Alcool;
            //    veiculo.Cambio = Cambio.Automatico;

            //    veiculo.Modelo = new ModeloRepositorio().Selecionar(1);
            //    veiculo.Cor = new CorRepositorio().Selecionar(1);


        }



    }
}