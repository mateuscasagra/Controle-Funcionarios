namespace ControleFuncionario.Models;
using System.ComponentModel.DataAnnotations;

public class Cargo
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }

    public List<Funcionario> Funcionarios { get; set; } = new();



   public Cargo() { }
}