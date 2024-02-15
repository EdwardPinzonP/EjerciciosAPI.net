using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PromedioController : ControllerBase
{
    [HttpGet("Calcular promedio")]
    public IActionResult CalcularPromedio(double numero1, double numero2, double numero3)
    {
        if (numero1 < 0 || numero2 < 0 || numero3 < 0)
        {
            return BadRequest(new { Error = "Por favor, ingrese números enteros positivos" });
        }
        else
        {
            double promedio = (numero1 + numero2 + numero3) / 3;
            return Ok(new { Promedio = promedio });
        }
    }
}