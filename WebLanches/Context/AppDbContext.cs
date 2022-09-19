using WebLanches.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebLanches.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; } // Cria uma tabela no Banco
        public DbSet<Lanche> Lanches { get; set; } // Cria uma tabela no Banco
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; } // Cria uma tabela no Banco
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }

    }
}

