using FluentValidation;
using GestaoTarefa.Domain.Contracts.UseCases.Tarefas;
using GestaoTarefa.WebApi.Models.Error;
using GestaoTarefa.WebApi.Models.Tarefa;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace GestaoTarefa.WebApi.Controllers.Tarefa
{
    [Route("api/Tarefa/[controller]")]
    [ApiController]
    public class AddTarefaController : ControllerBase
    {
        private readonly IAddTarefaUseCase _iAddTarefa;
        private readonly IValidator<AddTarefaInput> _addTarefaInputValidator;
        private readonly ILogger<AddTarefaController> _logger;

        public AddTarefaController(IAddTarefaUseCase iTarefa, IValidator<AddTarefaInput> addTarefaInputValidator, ILogger<AddTarefaController> logger)
        {
            _iAddTarefa = iTarefa;
            _addTarefaInputValidator = addTarefaInputValidator;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult AddTarefa(AddTarefaInput input)
        {
            _logger.LogInformation("Iniciando validação do input.");
            var validationResult = _addTarefaInputValidator.Validate(input);

            if (!validationResult.IsValid)
            {
                _logger.LogWarning("Validação falhou: {Errors}", validationResult.Errors);
                return BadRequest(validationResult.Errors.ToCustomValidationFailure());
            }

            var tarefa = new Domain.Entities.Tarefa(input.Titulo, input.Descricao, input.DtVencimento, (Domain.Entities.StatusTarefa)input.Status);

            _iAddTarefa.AddTarefa(tarefa);

            _logger.LogInformation("Tarefa adicionada com sucesso.");
            return Created("", tarefa);
        }
    }
}
