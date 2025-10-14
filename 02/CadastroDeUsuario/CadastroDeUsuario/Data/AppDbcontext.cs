using CadastroDeUsuario.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeUsuario.Data
{
    internal class AppDbcontext : DbContext
    {
     public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options) 
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}