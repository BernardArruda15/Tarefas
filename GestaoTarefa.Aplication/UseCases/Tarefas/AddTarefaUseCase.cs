using GestaoTarefa.Domain.Contracts.UseCases.Tarefas;
using GestaoTarefa.Domain.Entities;
using GestaoTarefa.Domain.Repositories.Tarefas;

namespace GestaoTarefa.Aplication.UseCases.Tarefas
{
    public class AddTarefaUseCase : IAddTarefaUseCase
    {
        private readonly IAddTarefaRepository _tarefaRepository;

        public AddTarefaUseCase(IAddTarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public void AddTarefa(Tarefa tarefa)
        {
            _tarefaRepository.AddTarefa(tarefa);
        }
    }
}
