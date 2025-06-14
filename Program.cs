using SoapCore;
using MyDualApi.Services;
using MyDualApi.Soap;
using SoapCore.Extensibility;

// Define the builder and configure services
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Registering the custom fault exception transformer for SOAP
builder.Services.AddSingleton<IFaultExceptionTransformer, LoggingFaultExceptionTransformer>();

// Registering services for both REST and SOAP (binding)
builder.Services.AddSingleton<IGreetingService, GreetingService>();
builder.Services.AddSingleton<IGreetingSoapService, GreetingSoapService>();

// Application configuration
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();

// REST endpoint registration (Top-level route registration)
app.MapControllers();

// SOAP endpoint registration (Top-level route registration)
((IApplicationBuilder)app).UseSoapEndpoint<IGreetingSoapService>("/GreetingService.svc",
    new SoapEncoderOptions(),
    SoapSerializer.DataContractSerializer);

app.Run();
