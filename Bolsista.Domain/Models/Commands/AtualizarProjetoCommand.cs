using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models.Commands
{
    public class AtualizarProjetoCommand
    {
        public string Nome { get; set; }
        public string Objetivo { get; set; }
        public string Metodologia { get; set; }
        public string ResultadosEsperados { get; set; }

    }
}
