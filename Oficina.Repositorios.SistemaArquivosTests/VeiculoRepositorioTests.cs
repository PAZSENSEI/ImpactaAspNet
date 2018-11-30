using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {

            var veiculo = new Veiculo();
            
            veiculo.Ano = 2014;
            veiculo.Placa = "ASD1221";
            veiculo.Modelo = new ModeloRepositorio().Selecionar(1);
            veiculo.Cor = new CorRepositorio().Selecionar(1);
            veiculo.Combustivel = Combustivel.Diesel;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Observacoes = "Observação";
            
            new VeiculoRepositorio().Inserir(veiculo);
            
        }
    }
}