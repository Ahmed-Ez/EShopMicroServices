var builder = WebApplication.CreateBuilder(args);

//Add services to container

var app = builder.Build();


//Register HTTP pipeline

app.Run();
