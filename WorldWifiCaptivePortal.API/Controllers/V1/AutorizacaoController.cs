namespace WorldWifiCaptivePortal.API.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("v{version:apiVersion}/[controller]")]
public class AutorizacaoController : ControllerBase
{
    private static readonly List<string> CpfsAutorizados = ["12345678900", "09876543211"];

    [HttpPost("verifica-cpf")]
    public IActionResult VerificaCpf([FromForm] string cpf)
    {
        if (CpfsAutorizados.Contains(cpf))
        {
            return Ok("Autorizado");
        }

        return Unauthorized("Não autorizado");
    }
}
