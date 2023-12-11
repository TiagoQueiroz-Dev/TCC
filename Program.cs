using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TCC.Database;
using TCC.Repository;
using TCC.Repository.Nota;
using TCC.Repository.Pedido;
using TCC.Repository.Usuario;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string mySqlConnection = builder.Configuration.GetConnectionString("Conexao");
builder.Services.AddDbContext<BancoContext>(opt => {
opt.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection));
});
builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<BancoContext>().AddDefaultTokenProviders();

builder.Services.AddScoped<IEstoqueRepository, EstoqueRepository>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<INotaRepository, NotaRepository>();
builder.Services.AddScoped<IUsuarioRepository,UsuarioRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
