using FluentValidation;
using Microsoft.AspNetCore.Routing.Constraints;

namespace GestaoTarefa.WebApi.Models.Tarefa
{
    public class AddTarefaInputValidator : AbstractValidator<AddTarefaInput>
    {
        public AddTarefaInputValidator()
        {
            RuleFor(x => x.Titulo)
                .NotEmpty()
                .NotNull();
        }
    }
}
