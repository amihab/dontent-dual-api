# .NET application that impplemets dual api consumption using WSDL and REST

The logic of this application is to implement both REST and SOAP endpoints.
The REST endpoint is implemented using ASP.NET Core, while the SOAP endpoint is implemented using SoapCore, which allows for SOAP support in .NET Core applications.

## Prerequisites

- .NET SDK 8.0 or later
- SoapCore library for SOAP support

## Run the Application locally
```bash
dotnet run
```

## Test the Endpoints
### REST Endpoint
[MyDualApi.http](MyDualApi.http)
### SOAP Endpoint
Use SoapUI or any SOAP client to test the SOAP endpoint. The WSDL is available at:
```
http://localhost:5059/GreetingService.svc?wsdl
```