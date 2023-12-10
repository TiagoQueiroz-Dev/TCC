using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TCC.Models;

namespace TCC.Database;

public class BancoContext : DbContext
{
    public BancoContext(DbContextOptions<BancoContext> options) : base(options){}

    public DbSet<EstoqueModel> EstoqueGeral { get; set; }
    public DbSet<PedidoModel> Pedidos { get; set; }
    public DbSet<NotaModel> Notas { get; set; }

}