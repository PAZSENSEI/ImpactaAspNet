using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.Repeticao.Testes
{
    [TestClass]
    public class RepeticaoTestes
    {
        [TestMethod]
        public void ForAninhadoTeste()

        {

            for (var i = 0; i <= 10; i++) //enquanto inteiro i for menor que 10
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($" {i} * {j} = {i * j}");
                    
                }

                Console.WriteLine(new string('-', 50));



            }





        }

        [TestMethod]
        public void EstruturaForTeste()

        {

            var i = 1;

            for (Console.WriteLine("Iniciou"); i < 3; Console.WriteLine(i))

            i++;


        }


        [TestMethod]
        public void ForApenasCondicaoTeste()
        {
            var i = 1;
            for (;i <- 3;)
                {
                Console.WriteLine(i++);
            }
        }

        [TestMethod]
        public void ContinueTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i <= 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void BreakTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i > 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }

    //VETORES, SIMILAR À LISTA.LIST, SERVE PARA GUARDAR ITEMS E VALORES.
}
