using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using Oficina.Repositorios.SistemaArquivos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Configuration.ConfigurationManager;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio : RepositorioBase
    {
        //ToDo: OO implementar método de extensão
        private string caminhoArquivo;

        public CorRepositorio()
        {
            caminhoArquivo = ObterCaminhoCompleto("caminhoArquivoCor");
        }


        //ToDo: OO - Polimosfismo por Sobrecarga
        public List<Cor>Selecionar()
        {
            var cores = new List<Cor>();

            foreach (var Linha in File.ReadAllLines(caminhoArquivo)) // a barra invertida nume string executa uma ação do VB, aqui ou usa duas barras \\ ou coloca @ como: @"Dados\Cor.txt"
            {

                var cor = new Cor();

                cor.Id = Convert.ToInt32(Linha.Substring(0, 5)) ;
                cor.Nome = Linha.Substring(5);

                cores.Add(cor);
                
            }
            return cores;
            
        }


        public Cor Selecionar(int id)
        {

            Cor cor = null;
            
            foreach (var Linha in File.ReadAllLines(caminhoArquivo))
            {
                var linhaId = Linha.Substring(0, 5);

                if (Convert.ToInt32(linhaId) == id)
                {
                    cor = new Cor
                    {
                        Id = Convert.ToInt32(Linha.Substring(0, 5)),
                        Nome = Linha.Substring(5)
                    };

                    //cor = new Cor
                    //{
                    //    Id = Convert.ToInt32(Linha.Substring(0, 5)),
                    //    Nome = Linha.Substring(5)
                    //};

                    break;
                }
            }

            return cor;

            
        }






    }
}
