using ControleFuncionario.Data;
using ControleFuncionario.Models;
using Microsoft.EntityFrameworkCore;



namespace ControleFuncionario.Rotas;

public static class CargosGetRoutes
{
    public static void MapCargosGetRoutes(this WebApplication app)
    {
        app.MapGet("/admin/cargos", async (AppDbContext db) =>
        {
            var cargos = await db.Cargos.ToListAsync();
            return Results.Ok(cargos);
        });
    }
}