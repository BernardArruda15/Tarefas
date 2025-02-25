using GestaoTarefa.Domain.Entities;

namespace GestaoTarefa.Domain.Contracts.UseCases.Tarefas
{
    public interface IAddTarefaUseCase
    {
        void AddTarefa(Tarefa tarefa);
    }
}
