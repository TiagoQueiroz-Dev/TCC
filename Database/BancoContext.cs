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
<<<<<<< HEAD
    public DbSet<UsuarioModel> Usuarios { get; set; }

    
=======

>>>>>>> 97f4ad56ddc03c1e918587a1b3a26c5a040c0c54
}