﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using Loja.Dominio;

namespace Loja.Repositorios.SqlServer
{
    internal class LojaBrInicializer :
        DropCreateDatabaseIfModelChanges<LojaDbContext>
    {
        protected override void Seed(LojaDbContext context)
        {
            context.Produtos.AddRange(ObterProdutos());
            context.SaveChanges();
        }

        private IEnumerable<Produto> ObterProdutos()
        {

            var grampeador = new Produto();

            grampeador.Categoria = new Categoria { Nome = "Papelaria" };
            grampeador.Estoque = 8;
            grampeador.Nome = "grampeador";
            grampeador.Preco = 22.08m;

            var penDrive = new Produto();
            penDrive.Categoria = new Categoria { Nome = "Informática" };
            penDrive.Estoque = 29;
            penDrive.Nome = "Pen Drive";
            penDrive.Preco = 22.30m;

            return new List<Produto> { grampeador, penDrive };

        }
    }
}