using ControleFuncionario.Data;
using ControleFuncionario.Models;
using Microsoft.EntityFrameworkCore;



namespace ControleFuncionario.Rotas;

public static class FuncionariosGetRoutes
{
    public static void MapFuncionariosGetRoutes(this WebApplication app)
    {
        app.MapGet("/admin/funcionarios", async (AppDbContext db) =>
        {
            var funcionarios = await db.Funcionarios.ToListAsync();
            return Results.Ok(funcionarios);
        });
    }
}