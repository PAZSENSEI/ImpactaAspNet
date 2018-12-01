using System;
using System.Collections.Generic;

namespace Oficina.Dominio
{
    public abstract class Veiculo //indica que ela pode ser instanciada por outros chamados/classes
    {
       
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Placa { get; set; }
        public int Ano { get; set; }
        public string Observacoes { get; set; }
        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }

        public abstract List<string> Validar();

        public List<string> ValidarBase() {
            var erros = new List<string>();
            if (Ano < 1980 || Ano > DateTime.Now.Year + 1)
            {
                erros.Add($"O ano informado({Ano}) não e válido");

            }
            return erros;
        }
    }

}