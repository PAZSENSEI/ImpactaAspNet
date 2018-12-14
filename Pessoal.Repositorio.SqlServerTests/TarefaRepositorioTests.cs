﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pessoal.Dominio.Entidades;
using Pessoal.Repositorio.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoal.Repositorio.SqlServer.Tests
{
    [TestClass()]
    public class TarefaRepositorioTests
    {
        private readonly TarefaRepositorio repositorio = new TarefaRepositorio();

        [TestMethod()]
        public void InserirTest()
        {

            var tarefa = new Tarefa();
            tarefa.Concluida = false;
            tarefa.Nome = "Passar";
            tarefa.Observacoes = "Rapido";
            tarefa.Prioridade = Prioridade.Alta;
            tarefa.Id = repositorio.Inserir(tarefa);
            Assert.AreNotEqual(tarefa.Id, 0);

        }

        [TestMethod()]
        public void AtualizarTest()
        {
            var tarefa = new Tarefa();
            tarefa.Id = 1;
            tarefa.Concluida = true;
            tarefa.Nome = "Passei";
            tarefa.Observacoes = "Rapido2";
            tarefa.Prioridade = Prioridade.Baixa;

            repositorio.Atualizar(tarefa);
        }
    }
}