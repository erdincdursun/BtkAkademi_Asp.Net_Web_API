var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//Service(Container)
builder.Services.AddControllers();


app.Run();
