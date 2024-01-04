using Microsoft.AspNetCore.Mvc;

namespace HangWire.UI.Web.Controllers;

[Route("hooks")]
public class HooksController : Controller
{
  [HttpGet("instagram")]
  public async Task<IActionResult> GetInstagramWebhook([FromQuery(Name = "hub.mode")] string mode, [FromQuery(Name = "hub.challenge")] int challenge, [FromQuery(Name = "hub.verify_token")] string verifyToken)
  {
    IActionResult actionResult;
    try
    {
      actionResult = this.StatusCode(200, challenge);
    }
    catch (Exception exception)
    {
      actionResult = this.StatusCode(500, exception.Message);
    }

    return actionResult;
  }

}

