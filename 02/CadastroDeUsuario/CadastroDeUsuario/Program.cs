using CadastroDeUsuario.Controller;
using CadastroDeUsuario.Data;
using CadastroDeUsuario.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
.ConfigureServices((Context, services) =>
{
    services.AddDbContext<AppDbcontext>(options => 
    options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=UsuariosDB;Trusted_Connection=True;"));

    services.AddTransient<UsuarioController>();
    services.AddTransient<ProdutoController>();

}).Build();

var usuarioController = host.Services.GetRequiredService<UsuarioController>();
var produtoController = host.Services.GetRequiredService<ProdutoController>();

MenuPrincipal();
MenuProdutos();

void MenuPrincipal()
{
    bool sair = false;
    while (!sair)
    {
        Console.Clear();
        Console.WriteLine("=== Menu Principal ==="); 
        Console.WriteLine("1. Gerenciar Usuario");
        Console.WriteLine("2. Gerenciar Produto");
        Console.WriteLine("0. Sair");

        string? opcao = Console.ReadLine();

        if (opcao == "1")
        {
           MenuUsuario();
        }
        else if (opcao == "2")
        {
            MenuProdutos();
        }
        else if (opcao == "0")
        {
            sair = true;
        }

    }
    }

void MenuUsuario()
{
    bool voltar = false;
    while (!voltar)

    {
        
        Console.Clear();
        Console.WriteLine("=== Gerenciar Usuario ===");
        Console.WriteLine("1. Listar Usuario");
        Console.WriteLine("2. Detalhes do Usuario");
        Console.WriteLine("3. Cadastrar Usuario");
        Console.WriteLine("4. Atualizar Usuario por ID");
        Console.WriteLine("5. Remover Usuario");
        Console.WriteLine("0. Voltar ");

        string? opcao = Console.ReadLine();

        switch (opcao)
        {
           
            case "1":
                usuarioController.Listar();
                break;
            case "2":   
                usuarioController.Detalhes();
                break;

                case "3":
                usuarioController.Adicionar();
                break;

                case "4":
                    usuarioController.AtualizarUsuario();
                break;

            case "5":
                    usuarioController.Remover();
                break;

            case "0":   
                voltar = true;
                break;
        }

        }
}

void MenuProdutos()
{
    bool sair = false;
    while (sair)

    {

        Console.Clear();
        Console.WriteLine("=== Gerenciar Produto ===");
        Console.WriteLine("1. Listar Produto");
        Console.WriteLine("2. Detalhes do Produto");
        Console.WriteLine("3. Cadastrar Produto");
        Console.WriteLine("4. Remover Produto");
        Console.WriteLine("0. Voltar ");

        string? opcao = Console.ReadLine();

      

        switch (opcao)
        {

            case "1":
                produtoController.Listar();
                break;
            case "2":
                produtoController.Detalhes();
                break;

            case "3":
                produtoController.Adicionar();
                break;

            case "4":
                produtoController.Remover();
                break;

            case "0":
                sair = true;
                break;
        }

    }
}