using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models.Commands
{
    public class AtualizarBolsistaCommand
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public long IdProjeto { get; set; }
    }
}
