using CadastroDeUsuario.Data;
using CadastroDeUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario.Controller
{
    internal class ProdutoController
    {
        private AppDbcontext _context; 

        public ProdutoController(AppDbcontext context) 
        { 
            _context = context;
        }
         
        public void Adicionar()
        {
            //Solicitar os Dados do produto 

            Console.WriteLine("Nome do Produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Preco do Produto: ");
            Decimal preco = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Data de Vencimento: ");
            DateOnly vencimento = DateOnly.Parse(Console.ReadLine());

            var novoProduto = new Produto();
            {
                novoProduto.Nome = nome;
                novoProduto.Preco = preco;
                novoProduto.Vencimento = vencimento;

            }
            ;
            _context.Produtos.Add(novoProduto);
            _context.SaveChanges();
        }

      

        public void Listar()
        {
            var Produtos = _context.Usuarios.ToList();

            if (Produtos.Count == 0)
            {
                Console.WriteLine("Nenhum Produto encontrado!");
            }
            else

                foreach (var Produto in Produtos) 
                {
                    Console.WriteLine($"ID: {Produto.Id} - Nome: {Produto.Nome}");

                }

            Console.WriteLine("Pressione qualquer tecla para sair ");
            Console.ReadKey();
        }

        public void Detalhes()
        {
            // Dizer onde estou
            Console.Clear();
            Console.WriteLine("=== Detalhes do Usuario ===");

            // Pedir o ID do usuario
            Console.WriteLine("Digite o ID do usuario: ");
            var idProduto = int.Parse(Console.ReadLine());

            // Buscar o usuario no banco de dados   
            var Produto = _context.Produtos.FirstOrDefault(user => user.Id == idProduto);

            // Se nao encontrar, avisar o usuario

            if (Produto == null)
            {
                Console.WriteLine("Produto nao encontrado!");
            }
            else // Se encontrar, mostrar os detalhes do usuario
            {
                Console.WriteLine(" --- Dados do Produto --- ");
                Console.WriteLine($"ID: {Produto.Id}");
                Console.WriteLine($"Nome: {Produto.Nome}");
                Console.WriteLine($"Preço: {Produto.Preco}");
                Console.WriteLine($"Vencimento: {Produto.Vencimento}");
            }

            Console.WriteLine("Pressione qualquer tecla para sair ");
            Console.ReadKey();
        }

        public void Remover()
        {
            Console.Clear();
            Console.WriteLine("=== Remover Produto ===");
            Console.WriteLine("Digite o ID do usuario que deseja remover: ");
            var idProduto = int.Parse(Console.ReadLine()!);


            // Buscar o usuario no banco de dados
            var ProdutoParaDeletar = _context.Produtos.FirstOrDefault(user => user.Id == idProduto);

            // Se nao encontrar, avisar o usuario
            if (ProdutoParaDeletar == null)
            {
                Console.WriteLine("Produto nao encontrado!");
                Console.ReadKey();
                return;
            }

            // Se encontrar, deletar o usuario do banco de dados
            _context.Produtos.Remove(ProdutoParaDeletar);
            _context.SaveChanges();

            Console.WriteLine(" Produto removido com sucesso!");
            Console.ReadKey();
        }

    }
}

    

