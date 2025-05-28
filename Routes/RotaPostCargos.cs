using ControleFuncionario.Data;
using ControleFuncionario.Models;

namespace ControleFuncionario.Rotas;


public static class CargosPostRoutes
{
    public static void MapCargosPostRoutes(this WebApplication app)
    {
        app.MapPost("/admin/cargos", async (Cargo cargo, AppDbContext db) =>
        {
            db.Cargos.Add(cargo);
            await db.SaveChangesAsync();
            return Results.Created($"/admin/cargos/{cargo.Id}", cargo);
            
        }) ;
    }
}