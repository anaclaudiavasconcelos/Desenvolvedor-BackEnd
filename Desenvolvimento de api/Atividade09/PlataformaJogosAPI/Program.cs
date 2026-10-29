using PlataformaJogosAPI.Models.Contextos;

var builder = WebApplication.CreateBuilder(args);

//Conectar banco de dados
ContextoJogo contextoJogo = new ContextoJogo();
contextoJogo.Database.EnsureCreated();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
