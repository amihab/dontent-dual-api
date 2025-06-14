using MyDualApi.Services;

namespace MyDualApi.Soap;

public class GreetingSoapService : IGreetingSoapService
{
    private readonly IGreetingService _greetingService;

    public GreetingSoapService(IGreetingService greetingService)
    {
        _greetingService = greetingService;
    }

    public string SayHello(string name)
    {
        return _greetingService.SayHello(name);
    }

    public string SayHelloFull(string name, int  age, bool isMale)
    {
        return _greetingService.SayHelloFull(name, age, isMale);
    }
}
