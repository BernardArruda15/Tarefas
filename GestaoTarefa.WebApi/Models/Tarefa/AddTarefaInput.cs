using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GestaoTarefa.WebApi.Models.Tarefa
{
    public class AddTarefaInput
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }
        
        public DateTime DtVencimento { get; set; }

        public StatusTarefa Status { get; set; }
    }
}
