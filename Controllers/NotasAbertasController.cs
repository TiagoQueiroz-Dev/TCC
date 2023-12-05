using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using TCC.Database;
using TCC.Models;
using TCC.Repository.Nota;
using TCC.Repository.Pedido;

namespace TCC.Controllers
{
    public class NotasAbertasController : Controller
    {

        public readonly INotaRepository _notaRespository;
        public readonly IPedidoRepository _pedidoRepository;

        public NotasAbertasController(INotaRepository notaRepository,IPedidoRepository pedidoRepository)
        {
            _notaRespository = notaRepository;
            _pedidoRepository = pedidoRepository;
        }

        public IActionResult Index()
        {       
                EstoquePedidoNotaModel notasPedidosAbertos = new EstoquePedidoNotaModel();
                ListaConsultaNotasModel lista = new ListaConsultaNotasModel();
                
                notasPedidosAbertos.ListaNotas = lista;
               
                notasPedidosAbertos.ListaNotas.NotasEncontradas = _notaRespository.NotasAbertas();
                
                return View(notasPedidosAbertos);
        }
    }
}