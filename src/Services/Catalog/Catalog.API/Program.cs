var builder = WebApplication.CreateBuilder(args);

// Add Services

var app = builder.Build();

// Configure HTTP Request Pipeline

app.Run();
