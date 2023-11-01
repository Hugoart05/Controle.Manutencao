using ControleManutencaoPreventiva.Models;
using ControleManutencaoPreventiva.Service.Interface;
using ControleManutencaoPreventiva.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ControleManutencaoPreventiva.Controllers
{
    public class EquipamentoController : Controller
    {
        private readonly IEquipamento _equipamento;

        public EquipamentoController(IEquipamento equipamento)
        {
            _equipamento = equipamento;
        }

        public IActionResult PegarTodos(int id)
        {
            var equipamentos = _equipamento.EquipamentosCondominio(id);
            if(equipamentos == null)
            {
                return NotFound();
            }

            return Ok(equipamentos);
        }
        public IActionResult Deletar(int id)
        {
            var equipamento = _equipamento.PegarPorId(id);
            if(equipamento == null)
            {
                return Ok(new { message = "Deletado com sucesso!" });
            }
            return Ok(new { message = "Algo deu errado!" });
        }
        public IActionResult Detalhes(int id)
        {
            var equipamento = _equipamento.PegarPorId(id);
            if( equipamento == null)
            {
                return BadRequest(new { message = "Equipamento inesistente!" });

            }
            return Ok(equipamento);
        }

        public IActionResult Adicionar([FromBody] Equipamento equipamento)
        {
            if(ModelState.IsValid)
            {
                _equipamento.Create(equipamento);
                return Ok(new { message = "Adicionado com sucesso!" });
            }
            return BadRequest(new { message = "Adicionado com sucesso!" });
        }

        public IActionResult Atualizar(Equipamento equipamento)
        {
            if (ModelState.IsValid)
            {
                _equipamento.Update(equipamento);
                return Ok("Atualizado com sucesso");
            }
            return BadRequest("Parametros invalidos!");
        }
    }
}
