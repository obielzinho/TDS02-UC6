using CadastroDeUsuario.Data;
using CadastroDeUsuario.Models;
using System.Diagnostics.Eventing.Reader;


namespace CadastroDeUsuario.Controller
{
    internal class UsuarioController    
    {
        private AppDbcontext _context;

        public UsuarioController(AppDbcontext context)
        {
            _context = context;
        }

        public void Adicionar()
        {
            //Solicitar os dados do usuario

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine()!;

            Console.WriteLine("SobreNome: ");
            string sobrenome = Console.ReadLine()!;

            Console.WriteLine("Data de Nascimento: ");
            DateOnly dataDeNascimento = DateOnly.Parse(Console.ReadLine()!);

            // Pedir Dados do usuario

            var novoUsuario = new Usuario();
            {
                novoUsuario.DataDeNascimento = dataDeNascimento;
                novoUsuario.Nome = nome;
                novoUsuario.Sobrenome = sobrenome;

            }
            ;

            _context.Usuarios.Add(novoUsuario);
            _context.SaveChanges();

            Console.WriteLine("Usuario cadastrado com sucesso!");
            Console.ReadKey();

        }

        public void Listar()
        {
            var usuarios = _context.Usuarios.ToList();

            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuario cadastrado!");
            }
            else

                foreach (var usuario in usuarios)
                {
                    Console.WriteLine($"ID: {usuario.Id} - Nome: {usuario.Nome}");

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
            var idUsuario = int.Parse(Console.ReadLine());

            // Buscar o usuario no banco de dados   
            var usuario = _context.Usuarios.FirstOrDefault(user => user.Id == idUsuario);

            // Se nao encontrar, avisar o usuario

            if (usuario == null)
            {
                Console.WriteLine("Usuario nao encontrado!");
            }
             else // Se encontrar, mostrar os detalhes do usuario
            {
                Console.WriteLine(" --- Dados do Usuario --- ");    
                Console.WriteLine($"ID: {usuario.Id}");
                Console.WriteLine($"Nome: {usuario.Nome}");
                Console.WriteLine($"Sobrenome: {usuario.Sobrenome}");
                Console.WriteLine($"Data de Nascimento: {usuario.DataDeNascimento}");
            }
            
            Console.WriteLine("Pressione qualquer tecla para sair ");
            Console.ReadKey();
        }

        public void Remover()
        {
            Console.Clear();
            Console.WriteLine("=== Remover Usuario ===");
            Console.WriteLine("Digite o ID do usuario que deseja remover: ");
            var idUsuario = int.Parse(Console.ReadLine()!);


            // Buscar o usuario no banco de dados
            var usuarioParaDeletar = _context.Usuarios.FirstOrDefault(user => user.Id == idUsuario);

            // Se nao encontrar, avisar o usuario
            if (usuarioParaDeletar == null) 
            {
                Console.WriteLine("Usuario nao encontrado!");
                Console.ReadKey();
                return;
            }

            // Se encontrar, deletar o usuario do banco de dados
            _context.Usuarios.Remove(usuarioParaDeletar);
            _context.SaveChanges();

            Console.WriteLine("Usuario removido com sucesso!");
            Console.ReadKey();
        }

        public void AtualizarUsuario()
        {

            Console.Clear();
            Console.WriteLine("=== Atualizar Usuario ===");
            Console.Write("Digite o ID do usuario ");
            var idUsuario = int.Parse(Console.ReadLine());

            var usuarioParaAtualizar = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == idUsuario);

            if (usuarioParaAtualizar == null)
            {
                Console.WriteLine("Usuario nao encontrado!");
                Console.ReadKey();
                return;
            }

            Console.Write($"Editando usuario: {usuarioParaAtualizar.Nome}");
            Console.Write(" Novo Primeiro nome: ");
            string? novoNome = Console.ReadLine();

            Console.Write(" Novo Sobrenome: ");
            string? novoSobrenome = Console.ReadLine();

            Console.Write(" Nova Data de Nascimento (AAAA-MM-DD): ");
            DateOnly novaDataDeNascimento = DateOnly.Parse(Console.ReadLine()!);

            usuarioParaAtualizar.Nome = novoNome;
            usuarioParaAtualizar.Sobrenome = novoSobrenome;
            usuarioParaAtualizar.DataDeNascimento = novaDataDeNascimento;

            _context.Usuarios.Update(usuarioParaAtualizar);
            _context.SaveChanges();

            Console.WriteLine("Usuario atualizado com sucesso!");
            Console.ReadKey();



        }

    }
}