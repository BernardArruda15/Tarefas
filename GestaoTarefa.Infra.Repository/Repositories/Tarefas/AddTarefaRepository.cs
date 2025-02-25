using GestaoTarefa.Domain.Entities;
using GestaoTarefa.Domain.Repositories.Tarefas;

namespace GestaoTarefa.Aplication.Repositories.Tarefas
{
    public class AddTarefaRepository : IAddTarefaRepository
    {
        private readonly IList<Tarefa> _tarefas = new List<Tarefa>();

        public void AddTarefa(Tarefa tarefa)
        {
            _tarefas.Add(tarefa);
        }
    }
}
