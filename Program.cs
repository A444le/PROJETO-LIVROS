using Microsoft.EntityFrameworkCore;
using ProjetoLivros.Context;

var builder = WebApplication.CreateBuilder(args);

//Codigos 
//dotnet ef migrations add Inicial // Crio a migration para o C# identificar o banco de dados
//dotnet ef database update // Crio o Banco de dados


//avisa que a aplicacao usa controllers
builder.Services.AddControllers();

//Adiciono o gerador de swagger
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LivrosContext>();
var app = builder.Build();

//Avisa o .NET que eu tenho controladores
app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(options => // Faz o Swagger abrir direto
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
app.MapGet("/", () => "Hello World!");

app.Run();





/* PASSO A PASSO CODE FIRST

1 - Criar as pastas Models e Context


2- criar as classes em Models ref. ao que foi pedido
prop+tab = criar uma propriedades
? = vai servir se for opcional 


3 - Criar os Contexts ref. ao que foi pedido
3.1 - Criar heranca e logo em seguida Dbcontext (so escrever DbContext+tab)
//3.2 - Criar os DbSet.      DbSet= Para criar uma tabela no Banco de Dados
3.3 - Criar um Ctor(Construtor)
3.4 - Metodo de sobrescrever 
3.4.5 - //String de conexao dentro do METODO SOBRESCREVER
3.5 - Criar os "tipos" do banco de dados, limites de cacteres
3.6 - Fazer o codigo representacao da tabela
3.6.1 - Criar as Primary Key 
3.6.1 - Criar campo a campo referente a models
3.7 - Criar as outras tabelas 

4 - Inserir os codigos no terminal para criar o code first

5 - Criar a Interface, Repository e Controller; (CRUD)

*/