using Bolsista.Domain.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models
{
    public class Projeto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Objetivo { get; private set; }
        public string Metodologia { get; private set; }
        public string ResultadosEsperados { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public Area Area { get; private set; }

        public Projeto(string nome, string objetivo, string metodologia, string resultadosEsperados) 
        {
            Nome = nome;
            Objetivo = objetivo;
            Metodologia = metodologia;
            ResultadosEsperados = resultadosEsperados;
        }

        public void Atualizar(AtualizarProjetoCommand command) 
        {
            Nome = command.Nome;
            Objetivo = command.Objetivo;
            Metodologia = command.Metodologia;
            ResultadosEsperados = command.ResultadosEsperados;
        }
    }
}
