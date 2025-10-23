using EstacionamentoSenac.API.D;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EstacionamentoSenacDB;Trusted_Connection=True;";

builder.Services.AddDbContext< AppDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
