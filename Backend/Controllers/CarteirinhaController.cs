using Backend.Models.Enums;
using Backend.Models.Request;
using Backend.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarteirinhaController : ControllerBase
    {
        [HttpGet]
        [Route("obter")]
        public IActionResult ObterCarteirinha([FromQuery] CarteirinhaRequest request)
        {
            //Se o pessoa nasceu antes de 1920, a data de nascimento está errada teoricamente ninguem
            //vivo nasceu antes de 1920
            if (request.Nascimento.Year < 1920)
            {
                return BadRequest($"A data de nascimento {request.Nascimento.ToShortDateString()}, parece estar errada");
            }

            var anoNascimento = request.Nascimento.Year;
            var anoAtual = DateTime.Now.Year;
            
            var idade = anoAtual - anoNascimento;

            var response = new CarteirinhaResponse();
            response.Nome = request.Nome;
            response.Nascimento = request.Nascimento;

            if (idade <= 12)
            {
                response.CorDeFundo = FaixaEtariaCor.Crianca;
            }
            else if (idade <= 17)
            {
                response.CorDeFundo = FaixaEtariaCor.Jovem;
            }
            else if (idade <= 59)
            {
                response.CorDeFundo = FaixaEtariaCor.Adulto;
            }
            else
            {
                response.CorDeFundo = FaixaEtariaCor.Idoso;
            }

            return Ok(response);
        }
    }
}
