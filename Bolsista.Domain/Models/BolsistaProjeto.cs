using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models
{
    public class BolsistaProjeto
    {
        public long Id { get; private set; }
        public string Nome {  get; private set; }
        public string CPF { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public long IdProjeto { get; private set; }
        public Projeto Projeto { get; private set; }

        public BolsistaProjeto(string nome, string cPF, DateTime dataInicio, DateTime dataFim, long idProjeto)
        {
            Nome = nome;
            CPF = cPF;
            DataInicio = dataInicio;
            DataFim = dataFim;
            IdProjeto = idProjeto;
        }

        public void Atualizar(DateTime dataInicio, DateTime dataFim, long idProjeto)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
            IdProjeto = idProjeto;
        }
    }
}
