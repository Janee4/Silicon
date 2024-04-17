using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribeController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Subscribe(string email) //hur man registrerar epost adressen: jo, via email. Dvs vi hämtar in en epost adress.
    { 
    return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> UnSubscribe(string email)
    {
        return Ok();
    }

}
