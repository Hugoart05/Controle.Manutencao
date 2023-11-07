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
        public ActionResult Index()
        {
            return View();
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

        [HttpGet("/datacondominio")]
        public async Task<IActionResult> TodosDadosRelacionados(int id)
        {
            var condominio = _condominio.PegarPorId(id);
            if(condominio  == null)
            {
                return NotFound();
            }
            
            return Ok(condominio);
        }

        [HttpPost("/adicionar")]
        public MessageViewModel Adicionar([FromBody] Condominio condominio)
        {
            var message = new MessageViewModel();
            
            if (ModelState.IsValid)
            {
                _condominio.Create(condominio);
                message.Message = "Condominio adicionado com sucess!";
                message.StatusCode = 200;
                return message;
            }

            message.Message = "Preencha os campos corretamente!";
            message.StatusCode = 222;
            return message;
        }
    }
}
