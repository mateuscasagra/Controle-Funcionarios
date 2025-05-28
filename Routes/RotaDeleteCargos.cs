using ControleFuncionario.Data;
using ControleFuncionario.Models;

namespace ControleFuncionario.Rotas;


public static class CargosDeleteRoutes
{
    public static void MapCargosDeleteRoutes(this WebApplication app)
    {
        app.MapDelete("/admin/cargos/{id:int}", async (int id, AppDbContext db) =>
        {
            var cargos = await db.Cargos.FindAsync(id);
            if (cargos == null)
                return Results.NotFound();
            db.Cargos.Remove(cargos);
            await db.SaveChangesAsync();
            return Results.NoContent();
            
        }) ;
    }
}