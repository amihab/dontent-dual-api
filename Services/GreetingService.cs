namespace MyDualApi.Services;

public class GreetingService : IGreetingService
{
    public string SayHello(string name)
    {
        return $"Hello, {name}! 👋";
    }
    public string SayHelloFull(string name, int age, bool isMale)
    {
        return $"Hello, {name}, age: {age}, male: {isMale}! 👋";
    }
}
