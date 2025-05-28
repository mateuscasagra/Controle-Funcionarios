using ControleFuncionario.Data;
using Microsoft.EntityFrameworkCore;
using ControleFuncionario.Rotas;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=controlefinaceiro.db"));


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();    });
});

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    DbInitializer.Initialize(dbContext);
}


app.MapFuncionariosGetRoutes();
app.MapCargosGetRoutes();

app.MapFuncionariosPostRoutes();
app.MapCargosPostRoutes();

app.MapFuncionariosDeleteRoutes();
app.MapCargosDeleteRoutes();
app.Run();