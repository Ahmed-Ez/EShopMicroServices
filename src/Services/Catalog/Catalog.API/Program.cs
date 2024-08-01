var builder = WebApplication.CreateBuilder(args);

// Add Services
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});

var app = builder.Build();

// Configure HTTP Request Pipeline
app.MapCarter();

app.Run();
