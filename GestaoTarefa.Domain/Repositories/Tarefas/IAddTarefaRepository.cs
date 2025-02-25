using GestaoTarefa.Domain.Entities;

namespace GestaoTarefa.Domain.Repositories.Tarefas
{
    public interface IAddTarefaRepository
    {
        void AddTarefa(Tarefa tarefa);
    }
}
