using Oficina.Dominio;
using Oficina.Repositorios;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
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
            var veiculo = new Veiculo();
            var formulario = HttpContext.Current.Request.Form;

            veiculo.Ano = Convert.ToInt32(formulario["ano"]);
            veiculo.Cambio = (Cambio)Convert.ToInt32(formulario["cambio"]);
            veiculo.Combustivel = (Combustivel)Convert.ToInt32(formulario["combustivel"]);
            veiculo.Cor = corRepositorio.Selecionar(Convert.ToInt32(formulario["cor"]));
            veiculo.Modelo = modeloRepositorio.Selecionar(Convert.ToInt32(formulario["modelo"]));

            veiculo.Observacoes = formulario["observacao"];
            veiculo.Placa = formulario["placa"];
            veiculoRepositorio.Inserir(veiculo);



            //    veiculo.Placa = "FTW-1836";
            //    veiculo.Observacao = "Observação";
            //    veiculo.Combustivel = Combustivel.Alcool;
            //    veiculo.Cambio = Cambio.Automatico;

            //    veiculo.Modelo = new ModeloRepositorio().Selecionar(1);
            //    veiculo.Cor = new CorRepositorio().Selecionar(1);

            new VeiculoRepositorio().Inserir(veiculo);
        }



    }
}