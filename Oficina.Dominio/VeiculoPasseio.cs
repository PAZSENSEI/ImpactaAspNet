using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    public class VeiculoPasseio : Veiculo
    {
        //ToDo: herança(:) com a classe Veiculo.
        public Carroceria Carroceria { get; set; }

        //todo: OO Polimosfismo por sobrescrita
        public override List<string> Validar()
        {
            var erros = ValidarBase();

            if (!Enum.IsDefined(typeof(Carroceria), Carroceria))
            {
                erros.Add($"A carroceria informada ({Carroceria}) não é válida");
            }

            return erros;
        }
    }
}
