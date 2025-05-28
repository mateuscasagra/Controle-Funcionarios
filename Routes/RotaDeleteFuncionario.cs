using ControleFuncionario.Data;
using ControleFuncionario.Models;

namespace ControleFuncionario.Rotas;


public static class FuncionarioDeleteRoutes
{
    public static void MapFuncionariosDeleteRoutes(this WebApplication app)
    {
        app.MapDelete("/admin/funcionarios/{cpf}", async (string cpf, AppDbContext db) =>
        {
            var funcionario = await db.Funcionarios.FindAsync(cpf);
            if (funcionario == null)
                return Results.NotFound();
            db.Funcionarios.Remove(funcionario);
            await db.SaveChangesAsync();
            return Results.NoContent();
            
        }) ;
    }
}