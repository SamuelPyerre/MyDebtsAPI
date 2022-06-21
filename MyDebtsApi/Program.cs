using MyDebtsApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<MyDebtsDbContext>();
var app = builder.Build();




//N�O USA MAIS O MapGet porque preciso acessar os Controllers
//app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();