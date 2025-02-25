Projeto de Gestao de tarefas

Criado conforme especificação 

Requisitos do Sistema:
Funcionalidades:

Cadastro de Tarefa:

O usuário deve poder criar uma nova tarefa. Para isso, o usuário deve fornecer:

-Título (obrigatório)
-Descrição (opcional)
-Data de vencimento (opcional)
-Status (com as opções: "Pendente", "Em progresso", "Concluída")

O sistema deve retornar um código único para cada tarefa criada.

Listagem de Tarefas:

O usuário deve poder visualizar todas as tarefas cadastradas.
O sistema deve permitir filtrar as tarefas por status e/ou data de vencimento.

Edição de Tarefa:

O usuário deve poder editar uma tarefa existente, incluindo a atualização do título, descrição, status e data de vencimento.

Exclusão de Tarefa:

O usuário deve poder excluir uma tarefa.

Requisitos Técnicos:

Utilize o framework .NET 6 (ou versão mais recente) para o desenvolvimento da API.
Aplique o princípio de SOLID em suas classes e controllers.
Utilize o Entity Framework Core para persistência de dados, utilize o InMemory para não haver necessidade de ter uma Base de Dados.
A aplicação deve seguir o padrão RESTful.
Utilize Swagger para documentar a API.
Aplique validações adequadas de entrada de dados.
Inclua testes automatizados utilizando xUnit ou NUnit para as camadas de lógica de negócios.

Considerações Adicionais:
Faça uso de DTOs (Data Transfer Objects) para a comunicação entre camadas.
A API deve retornar códigos de status HTTP apropriados (200, 201, 400, 404, etc.).
O projeto deve ser estruturado de forma modular e bem organizada, com camadas claras para as responsabilidades (por exemplo, camada de controlador, camada de serviço, camada de repositório, etc.).
Utilize dependência de injeção (Dependency Injection) para gerenciar as dependências.
Implemente um tratamento de erros adequado e um sistema de logging básico.

Foi utilizado Clean Architeture como design pattern e os conceitos de SOLID 

