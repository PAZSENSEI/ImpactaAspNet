using System;
using System.Collections.Generic;

namespace Oficina.Dominio
{

    public abstract class Veiculo //indica que ela pode ser instanciada por outros chamados/classes
    {
       //todo OO - classe (entidade) ou abstração
        public Guid Id { get; set; } = Guid.NewGuid();
        //public string Placa
        //{
        //    get
        //    {
        //        return Placa.ToUpper();
        //    }
        //    set
        //    {
        //        Placa = value.ToUpper();
        //    }
        //}

        private string placa;
        //ToDo: OO - encapsulamento
        public string Placa
        {
            get { return placa?.ToUpper(); }
            set { placa = value?.ToUpper(); }
        }


        public int Ano { get; set; }
        public string Observacoes { get; set; }
        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }

        public DateTime Agora {
            get { return DateTime.Now; }
        } 



        public abstract List<string> Validar();

        public List<string> ValidarBase() {
            var erros = new List<string>();
            if (Ano < 1980 || Ano > DateTime.Now.Year + 1)
            {
                erros.Add($"O ano informado({Ano}) não e válido");

            }
            return erros;
        }


        public override string ToString()
        {
            return string.Format("{0}{1}{2}", Modelo.Marca, Modelo.Nome, Placa);

        }
    }

}