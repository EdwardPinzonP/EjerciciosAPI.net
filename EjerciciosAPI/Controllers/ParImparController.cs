using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class NumeroParImparController : ControllerBase
{
    [HttpGet("Validar numero")]
    public IActionResult ValidarNumero(int? numero)
    {
        if (numero.HasValue)
        {
            string resultado = (numero % 2 == 0) ? $"El número {numero} es par" : $"El número {numero} es impar";
            return Ok(new { Resultado = resultado });
        }
        else
        {
            return BadRequest(new { Error = "Por favor, ingrese algún dato" });
        }
    }
}
