using ControleFuncionario.Data;
using ControleFuncionario.Models;

namespace ControleFuncionario.Rotas;


public static class FuncionarioPostRoutes
{
    public static void MapFuncionariosPostRoutes(this WebApplication app)
    {
        app.MapPost("/admin/funcionarios", async (Funcionario funcionario, AppDbContext db) =>
        {
            db.Funcionarios.Add(funcionario);
            await db.SaveChangesAsync();
            return Results.Created($"/admin/funcionarios/{funcionario.cpf}", funcionario);
            
        }) ;
    }
}