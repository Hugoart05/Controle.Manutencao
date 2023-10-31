using ControleManutencaoPreventiva.Context;
using ControleManutencaoPreventiva.Models;
using ControleManutencaoPreventiva.Service.Interface;
using ControleManutencaoPreventiva.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ControleManutencaoPreventiva.Controllers
{
    public class CondominioController : Controller
    {
        private readonly ICondominio _condominio;

        public CondominioController(ICondominio condominio)
        {
            _condominio = condominio;
        }

        public List<HomeViewModel> PegarTodos()
        {
            var listaDeCondominio = _condominio.PegarTodos();
            var viewModel = new List<HomeViewModel>();
            foreach(var item in listaDeCondominio)
            {
                var novoItem = new HomeViewModel
                {
                    Id = item.Id,
                    Name = item.Nome,
                };
                viewModel.Add(novoItem);
            }
            return viewModel;
            
        }

        [HttpGet("datacondominio")]
        public async Task<IActionResult> TodosDadosRelacionados(int id)
        {
            var condominio = _condominio.PegarPorId(id);
            if(condominio  == null)
            {
                return NotFound();
            }

            return Ok(condominio);
        }

        public   Adicionar()
        {

        }
    }
}
