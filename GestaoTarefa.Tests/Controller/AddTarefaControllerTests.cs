using FluentValidation;
using GestaoTarefa.Domain.Contracts.UseCases.Tarefas;
using GestaoTarefa.Domain.Entities;
using GestaoTarefa.WebApi.Controllers.Tarefa;
using GestaoTarefa.WebApi.Models.Tarefa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

public class AddTarefaControllerTests
{
    private readonly Mock<IAddTarefaUseCase> _mockAddTarefaUseCase;
    private readonly Mock<IValidator<AddTarefaInput>> _mockValidator;
    private readonly Mock<ILogger<AddTarefaController>> _mockLogger;
    private readonly AddTarefaController _controller;

    public AddTarefaControllerTests()
    {
        _mockAddTarefaUseCase = new Mock<IAddTarefaUseCase>();
        _mockValidator = new Mock<IValidator<AddTarefaInput>>();
        _mockLogger = new Mock<ILogger<AddTarefaController>>();
        _controller = new AddTarefaController(_mockAddTarefaUseCase.Object, _mockValidator.Object, _mockLogger.Object);
    }

    [Fact]
    public void AddTarefa_ValidInput_ReturnsCreatedResult()
    {
        // Arrange
        var input = new AddTarefaInput { Titulo = "Teste", Descricao = "Descrição", DtVencimento = DateTime.Now, Status = StatusTarefa.Pendente };
        _mockValidator.Setup(v => v.Validate(input)).Returns(new FluentValidation.Results.ValidationResult());

        // Act
        var result = _controller.AddTarefa(input);

        // Assert
        object value = Assert.IsType<CreatedResult>(result);
        _mockAddTarefaUseCase.Verify(u => u.AddTarefa(It.IsAny<Tarefa>()), Times.Once);
    }

    [Fact]
    public void AddTarefa_InvalidInput_ReturnsBadRequest()
    {
        // Arrange
        var input = new AddTarefaInput { Titulo = "Teste", Descricao = "Descrição", DtVencimento = DateTime.Now, Status = StatusTarefa.Pendente };
        var validationResult = new FluentValidation.Results.ValidationResult(new List<FluentValidation.Results.ValidationFailure> { new FluentValidation.Results.ValidationFailure("Titulo", "Erro") });
        _mockValidator.Setup(v => v.Validate(input)).Returns(validationResult);

        // Act
        var result = _controller.AddTarefa(input);

        // Assert
        object value = Assert.IsType<BadRequestObjectResult>(result);
        _mockAddTarefaUseCase.Verify(u => u.AddTarefa(It.IsAny<Tarefa>()), Times.Never);
    }
}