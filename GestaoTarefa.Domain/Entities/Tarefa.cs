using System;

namespace GestaoTarefa.Domain.Entities
{
    public class Tarefa
    {
        public Tarefa(string titulo, string descricao, DateTime dtVencimento, StatusTarefa status)
        {
            Titulo = titulo;
            Descricao = descricao;
            DtVencimento = dtVencimento;
            Status = status;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }

        public string Descricao { get; private set; }

        public DateTime DtVencimento { get; private set; }

        public StatusTarefa Status { get; private set; }
    }
}
