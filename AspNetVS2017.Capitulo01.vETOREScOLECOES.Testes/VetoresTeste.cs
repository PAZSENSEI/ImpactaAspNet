using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.vETOREScOLECOES.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var strings = new string[10];//entre[] vai o tamanho de vetores

            strings[0] = "A";
            strings[1] = "A";
            strings[2] = "A";
            strings[3] = "A";
            strings[4] = "A";
            strings[5] = "A";
            strings[6] = "A";
            strings[7] = "A";
            strings[8] = "A";
            strings[9] = "B";

            var decimais = new decimal[] { 0.5m, 78, 1.59m };

            foreach (var @decimal in decimais)
            {
                Console.WriteLine($"Tamanho do vetor: {decimais.Length}");
            }
        }
        
        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 78, 1.59m };

            Array.Resize(ref decimais, 5);

            decimais[3] = 20.01m;



        }
        
        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.5m, 78, 1.59m };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], 0.5);

            
        }

        private decimal Media( decimal valor1, decimal valor2)
            {
            
            return ((valor1 + valor2) / 2);
            
        }

        
        private decimal Medias(decimal[] valores)
        {
            
            decimal total = 0;

            foreach (var @decimal in valores)
            {

                total += @decimal;

            }

            return total / valores.Length;
        }

        private decimal Media(params decimal[] decimais)
        {

            return decimais.Average();


        }

        //toda string é um vetor de char(p|a|l|a|v|r|a)

        //sturdar string builder

        [TestMethod]
        public void TodaStringEhUmVetorTeste()

        { 
            const string nome = "Hejlsberg";
        Assert.AreEqual(nome[0], 'H');

            foreach (var @char in nome)
            {
                Console.WriteLine(@char);
            }
        }
    }



}
