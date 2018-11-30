﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetVS2017.Capitulo01.vETOREScOLECOES.Testes
{

    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTest()
        {

            var inteiros = new List<int>(50) { 2, 1, 2, 6, 125 };
            inteiros.Add(22);
            //inteiros[12] = 89;

            var maisInteiros = new List<int>{32, 72, 14, 6};
                inteiros.AddRange(maisInteiros);


            inteiros.Insert(0, 29); // insert na posição 0

            inteiros.Remove(2);//aqui informa o valor para ser removido
            //inteiros.RemoveAt(189);//aqui remove o valor da posição especificada
            inteiros.Sort();
            //var primeiro = inteiros[0];

            var primeiro = inteiros.FirstOrDefault();
            var ultimo = inteiros[inteiros.Count - 1];
            var estahVazia = inteiros.Count == 0;

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}: {inteiro}");

            }

            for (int i = 0; i < inteiros.Count; i++)
            {
                Console.WriteLine($"Para cada inteiros = { i} : { inteiros[i] }");

            }
        }
    
    

    [TestMethod]
    public void DictionaryTeste()
    {
        var feriados = new Dictionary<DateTime, string>();
        feriados.Add(new DateTime(2018, 12, 25), "Natal");
        feriados.Add(new DateTime(2019, 1, 1), "Ano Novo");
        feriados.Add(new DateTime(2019, 1, 25), "Niver SP");
        //feriados.Add(new DateTime(2019, 1, 25), "Niver Sobrinha");

        var natal = feriados[new DateTime(2018, 12, 25)];

        foreach (var feriado in feriados)
                    {

            //Console.WriteLine(String.Format("{0}: {1}", feriado.Key.ToShortDateString(), feriado.Value));
                Console.WriteLine(String.Format("{0:dd/MM}: {1}", feriado.Key.ToShortDateString(), feriado.Value));




        }
    }
    }
}

