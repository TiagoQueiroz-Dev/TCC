using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TCC.Models;

namespace TCC.Database;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options){}
    public DbSet<Estoque> EstoqueGeral { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Nota> Notas { get; set; }

}