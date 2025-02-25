using FluentValidation;
using GestaoTarefa.Aplication.Repositories.Tarefas;
using GestaoTarefa.Aplication.UseCases.Tarefas;
using GestaoTarefa.Domain.Contracts.UseCases.Tarefas;
using GestaoTarefa.Domain.Repositories.Tarefas;
using GestaoTarefa.WebApi.Models.Tarefa;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IAddTarefaRepository, AddTarefaRepository>();
builder.Services.AddScoped<IAddTarefaUseCase, AddTarefaUseCase>();
builder.Services.AddTransient<IValidator<AddTarefaInput>, AddTarefaInputValidator>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona o DbContext ao contêiner de serviços
builder.Services.AddDbContext<DbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    if (connectionString == "InMemory")
    {
        options.UseInMemoryDatabase("InMemoryDb");
    }
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

var cultureInfo = new CultureInfo("pt-BR");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

app.Run();
