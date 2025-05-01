using Microsoft.EntityFrameworkCore;
using ProjetoLivros.Context;

var builder = WebApplication.CreateBuilder(args);

//Codigos 
//dotnet ef migrations add Inicial // Crio a migration para o C# identificar o banco de dados
//dotnet ef database update // Crio o Banco de dados

builder.Services.AddDbContext<LivrosContext>();
var app = builder.Build();

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
3.7 - 

4 - Inserir os codigos no terminal para criar o code first
*/