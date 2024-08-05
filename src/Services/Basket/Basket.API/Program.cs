
var builder = WebApplication.CreateBuilder(args);

// Add Services
var assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(assembly);
    config.AddOpenBehavior(typeof(ValidationBehavior<,>));
    config.AddOpenBehavior(typeof(LogginBehavior<,>));
});

builder.Services.AddCarter();

var app = builder.Build();

// HTTP Pipeline
app.MapCarter();

app.Run();
