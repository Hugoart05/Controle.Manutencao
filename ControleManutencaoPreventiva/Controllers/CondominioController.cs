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
            var condominios = _condominio.PegarTodos();
            return View(condominios);
        }
        

        [HttpGet("/condominio")]
        public async Task<IActionResult> TodosDadosRelacionados(int id)
        {
            var condominio = _condominio.PegarPorId(id);
            if(condominio  == null)
            {
                return NotFound();
            }
            
            return Ok(condominio);
        }

        [HttpPost]
        public ActionResult Adicionar(Condominio condominio)
        {
            return RedirectToAction("Index");
        }
    }
}
