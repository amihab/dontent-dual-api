using Microsoft.AspNetCore.Mvc;
namespace MyDualApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GreetingController : ControllerBase
{
    private readonly IGreetingService _greetingService;

    public GreetingController(IGreetingService greetingService)
    {
        _greetingService = greetingService;
    }

    [HttpGet("{name}")]
    public ActionResult<string> GetGreeting(string name)
    {
        return _greetingService.SayHello(name);
    }

    [HttpGet("{name}/{age}")]
    public ActionResult<string> GetGreeting(string name, int age, [FromQuery] bool isMale)
    {
        return _greetingService.SayHelloFull(name, age, isMale);
    }
}
