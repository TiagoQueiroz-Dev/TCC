using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TCC.Database;
using TCC.Models;

namespace TCC.Repository.Nota
{
    public class NotaRepository : INotaRepository
    {
        public readonly BancoContext _bancoContex;

        public NotaRepository(BancoContext bancoContext)
        {
            _bancoContex = bancoContext;
        }

        public NotaModel AdicionarNota(NotaModel novaNota)
        {
            novaNota.StatusNota = true;
            _bancoContex.Notas.Add(novaNota);
            _bancoContex.SaveChanges();
            return novaNota;
        }

        public int BuscarIdNota(NotaModel nota)
        {
            //busca mediante a chave primaria
            var notaConsulta = _bancoContex.Notas.Find(nota.Id);

            return notaConsulta.Id;
        }

        public NotaModel BuscarNota(int id)
        {
            var nota = _bancoContex.Notas.Find(id);
            return nota;
        }

        public List<NotaModel> BuscarNotas(string pesquisa, string opcBusca)
        {

            List<NotaModel> listaDeBusca = new List<NotaModel>();

            switch (opcBusca)
            {
                case "CPF/CNPJ":
                    var notasCPF = _bancoContex.Notas.Where(u => u.CPF_CNPJ == int.Parse(pesquisa));
                    listaDeBusca = notasCPF.ToList();
                    break;
                case "NNota":
                    var notasId = _bancoContex.Notas.Where(u => u.Id == int.Parse(pesquisa));
                    listaDeBusca = notasId.ToList();
                    break;
                case "Cliente":
                    var notasCliente = _bancoContex.Notas.Where(u => u.Nome == pesquisa);
                    listaDeBusca = notasCliente.ToList();
                    break;
                case "Tel":
                    var notasTel = _bancoContex.Notas.Where(u => u.Telefone == int.Parse(pesquisa));
                    listaDeBusca = notasTel.ToList();
                    break;
                case "DATA-NOTA":
                    //a variavel de data deverá se alterada para tipo string
                    var notasDataInicial = _bancoContex.Notas.Where(u => u.DataEmissao == DateTime.Parse(pesquisa));
                    listaDeBusca = notasDataInicial.ToList();
                    break;
                case "DATA-RECOLHIMENTO":
                    //a variavel de data deverá se alterada para tipo string
                    var notasDataRecolhimento = _bancoContex.Notas.Where(u => u.DataRecolhimento == DateTime.Parse(pesquisa));
                    listaDeBusca = notasDataRecolhimento.ToList();
                    break;
                case "CEP":
                    var notasCEP = _bancoContex.Notas.Where(u => u.Cep == int.Parse(pesquisa));
                    listaDeBusca = notasCEP.ToList();
                    break;
            }
            return listaDeBusca;
        }
        public List<NotaModel> NotasAbertas(){
            List<NotaModel> abertas = new List<NotaModel>();

            var notas = _bancoContex.Notas.Where(u => u.StatusNota == true);
            abertas = notas.ToList();
            
            return abertas;
        }
    }
}