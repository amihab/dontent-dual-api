using System.ServiceModel;

namespace MyDualApi.Soap;

[ServiceContract]
public interface IGreetingSoapService
{
    [OperationContract]
    string SayHello(string name);

    [OperationContract]
    string SayHelloFull(string name, int age, bool isMale);
}
